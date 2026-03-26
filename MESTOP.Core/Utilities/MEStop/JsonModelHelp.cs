using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


 


namespace MESTOP.Core.Utilities
{
    public static class JsonModelHelp
    {

        public static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public static List<Dictionary<string, string>> listDic = new List<Dictionary<string, string>>();

        /// <summary>
        /// Json字符串 Key首字母大写以对应实体
        /// </summary>
        /// <param name="text"></param>
        /// <param name="toUp">true 大写 false 小写</param>
        /// <param name="changeDate">true \\/Date(xxxxxx)\\/ 反序列化至实体用false                   
        //xxxxxx序列化传出用</param>
        /// <returns></returns>
        public static string ChangeSourceJonson(string text, bool toUp, bool changeDate)
        {

            Regex rg = new Regex("[\"]+[a-zA-z]+[0-9]*[\"]+[:]+");
            MatchCollection keys = rg.Matches(text, 0);
            string firstcharacter = null;
            string newkey = null;
            List<string> hasreplacedkeys = new List<string>();
            List<int> deleteIndex = new List<int>();
            List<int> deleteLength = new List<int>();
            List<string> newStringValue = new List<string>();
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].Value.ToLower().Contains("time") || keys[i].Value.ToLower().EndsWith("birth"))
                {
                    for (int j = keys[i].Index + keys[i].Length; ; j++)
                    {
                        if (text.Substring(j, 1) == "," || text.Substring(j, 1) == "}")
                        {
                            string value = text.Substring(keys[i].Index + keys[i].Length, j - keys[i].Index - keys[i].Length);
                            string newvalue = null;
                            if (changeDate)
                            {
                                newvalue = value == "null" ? "\"\\/Date(" + "0" + ")\\/\"" : "\"\\/Date(" + value + ")\\/\"";
                            }
                            else if (!changeDate)
                            {
                                newvalue = value == "null" ? "0" : value;
                                if (value.StartsWith("\"") && value.EndsWith("\""))
                                {
                                    newvalue = value.Replace("\"", "");
                                    if (newvalue.Contains(" "))
                                    {
                                        newvalue = GetDateLong(newvalue).ToString();
                                    }
                                    else
                                    {
                                        newvalue = System.Convert.ToDateTime(newvalue).Ticks.ToString();
                                    }
                                }
                            }
                            deleteIndex.Add(keys[i].Index + keys[i].Length);
                            deleteLength.Add(value.Length);
                            newStringValue.Add(newvalue);
                            break;
                        }
                    }
                }
                if (!hasreplacedkeys.Contains(keys[i].Value))
                    hasreplacedkeys.Add(keys[i].Value);
                else continue;
                firstcharacter = keys[i].Value.Substring(1, 1);
                if (toUp)
                {
                    firstcharacter = firstcharacter.ToUpper();
                }
                if (!toUp)
                {
                    firstcharacter = firstcharacter.ToLower();
                }
                newkey = "\"" + firstcharacter + keys[i].Value.Substring(2);
                text = text.Replace(keys[i].Value, newkey);
            }

            for (int i = deleteLength.Count - 1; i >= 0; i--)
            {
                text = text.Remove(deleteIndex[i], deleteLength[i]);
                text = text.Insert(deleteIndex[i], newStringValue[i]);
            }
            text = text.Replace("\r", "\\r");
            text = text.Replace("\n", "\\n");

            return text;

        }

        /// <summary>
        /// Json字符串 Key首字母大写以对应实体
        /// </summary>
        /// <param name="JsonString"></param>
        /// <returns></returns>
        public static string ConvertJson(string JsonString)
        {
            listDic = new List<Dictionary<string, string>>();
            dictionary = new Dictionary<string, string>();
            bool IsList = false;
            string ss = "";
            StringBuilder Strb = new StringBuilder();
            if (JsonString.IndexOf('[') == 0)
            {
                IsList = true;
                JsonString = JsonString.Remove(0, 1);
                JsonString = JsonString.Remove(JsonString.Length - 1, 1);
                Strb.Append("[");
            }
            string Start1 = JsonString.Replace("\"", "");
            string[] start4 = Start1.Split('{');
            StringBuilder Str = new StringBuilder();
            for (int i = 0; i < start4.Length; i++)
            {
                dictionary = new Dictionary<string, string>();
                if (i != 0)
                {
                    Str.Append("{");
                    for (int index = 0; index < start4[i].Length; index++)
                    {
                        int tempKeyStartIndex = index;
                        int tempKeyEndIndex = start4[i].IndexOf(':');
                        string tempkey = start4[i].Substring(index, tempKeyEndIndex - tempKeyStartIndex);
                        index = tempKeyEndIndex;
                    }

                }

                string[] splits = start4[i].Split(',');
                for (int j = 0; j < splits.Length; j++)
                {
                    string SplitString = splits[j].Replace("]", "");
                    SplitString = splits[j].Replace("}", "");
                    SplitString.Trim();
                    if (SplitString != null && SplitString != string.Empty)
                    {
                        SplitString = SplitString.Substring(0, 1).ToUpper() + SplitString.Substring(1, SplitString.Length - 1);
                        string[] ThredSplit = SplitString.Split(':');
                        for (int index = 0; index < ThredSplit.Length; index++)
                        {
                            if (index == 0)
                            {
                                string Key = ThredSplit[index];
                                Str.Append('\"');
                                Str.Append(Key);
                                Str.Append('\"');
                                Str.Append(':');
                            }
                            if (index == 1)
                            {
                                string key = ThredSplit[index - 1];

                                string Value = ThredSplit[index];
                                if (key.Contains("Time") || key.Contains("time"))
                                {
                                    if (Value == "null")
                                    {
                                        Value = "0";
                                    }
                                    Value = @"/Date(" + Value + @")/";
                                }
                                Str.Append('\"');
                                Str.Append(Value);
                                Str.Append('\"');
                                Str.Append(',');
                                dictionary.Add(key, Value);
                            }
                        }
                    }
                }
                if (i != 0)
                {
                    Str.Append("}");
                    Str.Remove(Str.ToString().LastIndexOf(','), 1);
                    Str.Append(",");
                    if (IsList)
                    {
                        listDic.Add(dictionary);
                    }
                }
            }
            Str.Remove(Str.ToString().LastIndexOf(','), 1);
            Strb.Append(Str);
            if (IsList)
            {
                Strb.Append("]");//int count = 0;
            }
            return Strb.ToString();
        }

        /// <summary>
        /// Json转实体类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JsonString"></param>
        /// <returns></returns>
        public static T JsonToModel<T>(string JsonString)
        {
            //JsonString = ChangeSourceJonson(JsonString);
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(JsonString)))
            {
                try
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(T));
                    T returnOrg = (T)deseralizer.ReadObject(ms);
                    return returnOrg;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    ms.Close();
                    ms.Dispose();
                }
            }
        }

        /// <summary>
        /// Json反序列化批量转换实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JsonString"></param>
        /// <returns></returns>
        public static List<T> JsonToList<T>(string JsonString)
        {
            return JsonToModel<List<T>>(JsonString);
        }

        /// <summary>
        /// 序列化json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ModelToJson<T>(T t)
        {
            try
            {
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
                MemoryStream mobj = new MemoryStream();
                js.WriteObject(mobj, t);
                mobj.Position = 0;
                StreamReader sr = new StreamReader(mobj, Encoding.UTF8);
                string Json = sr.ReadToEnd();
                sr.Close();
                mobj.Close();
                return Json;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 转化为JsonBody用作请求传参
        /// </summary>
        /// <param name="dic">key value</param>
        /// <returns></returns>
        public static string ConvertToBodyJson(Dictionary<string, string> dic)
        {
            StringBuilder BodyJson = new StringBuilder();
            if (dic.Count != 0)
            {
                BodyJson.Append('{');
            }
            foreach (var item in dic)
            {
                if (item.Value != "" && item.Value != null)
                {
                    BodyJson.Append("\"");
                    BodyJson.Append(item.Key);
                    BodyJson.Append("\"");
                    BodyJson.Append(":");
                    if (item.Value.Contains("[") && item.Value.Contains("]"))
                    {
                        BodyJson.Append(item.Value);
                    }
                    else
                    {
                        BodyJson.Append("\"");
                        BodyJson.Append(item.Value);
                        BodyJson.Append("\"");
                    }
                    BodyJson.Append(",");
                }
            }
            if (BodyJson.ToString().LastIndexOf(',') != -1)
            {
                // MessageBox.Show(BodyJson.ToString());
                BodyJson.Remove(BodyJson.ToString().LastIndexOf(','), 1);

            }
            if (dic.Count != 0)
            {
                BodyJson.Append("}");
            }
            return BodyJson.ToString();
        }

        public static List<Dictionary<string, object>> JsonToListDictionary(string json)
        {
            List<Dictionary<string, object>> listDictionary = new List<Dictionary<string, object>>();
            List<int> indexs = new List<int>();
            int index = 0;
            List<string> stringList = new List<string>();
            if (json.StartsWith("["))
            {
                for (int i = 0; i < json.Length; i++)
                {
                    index = json.IndexOf("{", index + 1);
                    if (index == -1) break;
                    indexs.Add(index);
                }
                indexs.Add(json.LastIndexOf("}"));
                for (int i = 0; i < indexs.Count - 1; i++)
                {
                    stringList.Add(json.Substring(indexs[i], indexs[i + 1] - indexs[i]));
                }
                for (int i = 0; i < stringList.Count; i++)
                {
                    listDictionary.Add(JsonToDictionary(stringList[i], false));
                }
                return listDictionary;
            }
            return null;
        }

        /// <summary>
        /// Json返回值转化为字典处理 对应keyvalues字典
        /// </summary>
        /// <param name="json"></param>
        public static Dictionary<string, object> JsonToDictionary(string json, bool isUp)
        {
            Dictionary<string, object> keyvalues = new Dictionary<string, object>();
            if (json.StartsWith("{"))
            {
                int index = 0;
                bool addkey = true;
                int count = 0;
                string key = null;
                for (int i = 0; i < json.Length; i++)
                {
                    index = json.IndexOf("\"", index);
                    if (index == -1) break;
                    count++;
                    if (count % 2 == 1)
                    {
                        int index2 = json.IndexOf("\"", index + 1);
                        key = json.Substring(index + 1, index2 - index - 1);
                        if (string.IsNullOrEmpty(key)) break;
                        if (isUp)
                            key = key.ToUpper().Substring(0, 1) + key.Substring(1);
                        int indexof2dots = json.IndexOf(":", index2);
                        if (indexof2dots == -1) break;
                        int indexofdot = json.IndexOf(",", indexof2dots);
                        int indexof2dots_1 = json.IndexOf(":", indexof2dots + 1);
                        if (indexof2dots_1 != -1)
                        {
                            int indexofdot_1 = json.IndexOf(",", indexofdot + 1);
                            if (indexofdot_1 > indexofdot && indexofdot_1 < indexof2dots_1)
                                indexofdot = indexofdot_1;
                        }
                        string tempvalue = "";
                        if (indexofdot != -1)
                        {
                            tempvalue = json.Substring(indexof2dots + 1, indexofdot - indexof2dots - 1);
                        }
                        else
                        {
                            tempvalue = json.Substring(indexof2dots + 1, json.Length - 1 - indexof2dots - 1);
                            if (tempvalue.Length == 0)
                            {
                                tempvalue = json.Substring(indexof2dots + 1, 1);
                            }
                            if (tempvalue.StartsWith("\"") && !tempvalue.EndsWith("\""))
                            {
                                tempvalue = tempvalue.Substring(1);
                            }

                        }
                        tempvalue = tempvalue.Replace("}", "");

                        if (!tempvalue.Contains("[") && tempvalue.StartsWith("\"") && tempvalue.EndsWith("\""))
                        {
                            tempvalue = tempvalue.Substring(1, tempvalue.Length - 2);
                        }
                        string value = "";
                        if (index2 + 2 + 4 < json.Length)
                            value = json.Substring(index2 + 2, 4);
                        if (value.Contains("}"))
                        {
                            int index3 = json.IndexOf("\"", index2 + 1);
                            keyvalues.Add(key, "");
                            keyvalues[key] = json.Substring(index3 + 1, index3 - index2 - 1);
                            break;
                        }
                        string value1 = "";
                        if (index2 + 2 + 5 < json.Length)
                            value = json.Substring(index2 + 2, 5);

                        bool isNumber = false;
                        try { System.Convert.ToInt32(value1); isNumber = true; } catch { isNumber = false; }
                        if (isNumber)
                        {
                            for (int j = index2 + 7; ; j++)
                            {
                                try { System.Convert.ToInt32(json.Substring(j, 1)); value1 += json.Substring(j, 1); }
                                catch
                                {
                                    keyvalues.Add(key, value1);
                                    addkey = true;
                                    break;
                                }
                            }
                        }
                        else if (value == "null")
                        {
                            keyvalues.Add(key, "null");
                            addkey = true;
                        }
                        else if (value == "true")
                        {
                            keyvalues.Add(key, "true");
                            addkey = true;
                        }
                        else if (value1 == "false")
                        {
                            keyvalues.Add(key, "false");
                            addkey = true;
                        }
                        else if (!tempvalue.Contains("["))
                        {
                            keyvalues.Add(key, tempvalue);
                            if (indexofdot != -1)
                                index2 = indexofdot;
                            addkey = true;
                        }
                        else
                        {
                            keyvalues.Add(key, "");
                            addkey = false;
                        }
                        index = index2 + 1;
                        i = index;
                        if (keyvalues[key].ToString().Length > 1000 && !keyvalues[key].ToString().Contains("-") && !keyvalues[key].ToString().Contains(","))
                        {
                            keyvalues[key] = System.Convert.FromBase64String(keyvalues[key].ToString());
                        }


                    }
                    else if (!addkey)
                    {
                        int index2 = json.IndexOf("\"", index + 1);
                        if (json.Substring(index - 1, 1) == "[")
                        {
                            index2 = json.IndexOf("]", index + 1);
                            index--;
                        }
                        keyvalues[key] = json.Substring(index + 1, index2 - index - 1);
                        if (keyvalues[key].ToString().Length > 32 && !keyvalues[key].ToString().Contains("-") && !keyvalues[key].ToString().Contains(","))
                        {
                            keyvalues[key] = System.Convert.FromBase64String(keyvalues[key].ToString());
                        }
                        index = index2 + 1;
                        i = index;
                        addkey = true;
                    }
                }
                return keyvalues;
            }
            return null;
        }

        /// <summary>
        /// Post请求结果
        /// </summary>
        /// <param name="Json">Body Json数据</param>
        /// <param name="Url">请求地址</param>
        /// <returns></returns>
        public static String PostResultJson(string Json, string Url)
        {
            try
            {
                string Result = "";
                String URl = Url;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URl);
                req.Method = "POST";
                req.ContentType = "application/json";
                //Console.WriteLine("b");
                using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                {
                    //Console.WriteLine("c");
                    string json = Json;
                    streamWriter.Write(json);
                }
                var response = (HttpWebResponse)req.GetResponse();
                //Console.WriteLine("d");
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    //Console.WriteLine("e");
                    Result = streamReader.ReadToEnd();
                }
                return Result;
            }
            catch (ProtocolViolationException ex)
            {
                Console.WriteLine(ex.Message + "\r\nProtocolViolationException\r\n" + ex.StackTrace);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\r\nNotSupportedException\r\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
            }
            return null;
        }
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }

        /// <summary>
        /// Get请求结果
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <returns></returns>

        public static String GetResultJson(string Url)

        {

            try
            {
                string result = "";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                req.Method = "GET";
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取内容
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        /// <summary>
        /// Put请求结果
        /// </summary>
        /// <param name="Json">BodyJson</param>
        /// <param name="Url">请求地址</param>
        /// <returns></returns>
        public static String PutResultJson(string Json, string Url)
        {

            try
            {
                string Result = "";
                String URl = Url;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URl);
                req.Method = "PUT";
                req.ContentType = "application/json";
                if (Json != "" && Json != null)
                {
                    using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                    {
                        string json = Json;
                        streamWriter.Write(json);
                    }
                }
                var response = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    Result = streamReader.ReadToEnd();
                }
                return Result;
            }
            catch (ProtocolViolationException ex)
            {
                Console.WriteLine(ex.Message + "\r\nProtocolViolationException\r\n" + ex.StackTrace);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\r\nNotSupportedException\r\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        /// <summary>
        /// Delete请求结果
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <returns></returns>
        public static String DeleteResultJson(string Url)
        {

            try
            {
                string result = "";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
                req.Method = "DELETE";
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取内容
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Delete请求结果
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <returns></returns>
        public static String DeleteResultJson(string Json, string Url)
        {
            try
            {
                string Result = "";
                String URl = Url;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URl);
                req.Method = "DELETE";
                req.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                {
                    string json = Json;
                    streamWriter.Write(json);
                }
                var response = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    Result = streamReader.ReadToEnd();
                }
                return Result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// DateTime  转化LongTick
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long GetDateLong(object time)
        {
            DateTime epoc = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan delta = new TimeSpan();
            if (time is DateTime)
            {
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
                long t = (((DateTime)time).Ticks - startTime.Ticks) / 10000;   //除10000调整为13位      
                return t;
            }
            else if (time is string)
            {
                delta = DateTime.Parse(time.ToString()).Subtract(epoc);
            }

            long ticks = (long)delta.TotalMilliseconds;
            if (ticks < 0)
            {
                return 0;
            }
            return ticks;
        }

        /// <summary>
        /// LongTicks 转datetime
        /// </summary>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public static DateTime GetDateTimeFromLong(long ticks)
        {
            var date = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            date = date.AddMilliseconds(ticks);
            return date;
        }

        public static Dictionary<string, object> JsonOfPage(string Json)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            int EntitiesIndex = Json.IndexOf("entities");
            int TotalIndex = Json.IndexOf("total");
            string total = Json.Substring(TotalIndex + 7, EntitiesIndex - TotalIndex - 7 - 2);
            string Entities = Json.Substring(EntitiesIndex + 10, Json.Length - 1 - EntitiesIndex - 10);
            dictionary.Add("total", total);
            dictionary.Add("list", Entities);
            return dictionary;
        }


        /// <summary>
        ///  AES 加密
        /// </summary>
        /// <param name="str">明文（待加密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesEncrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return System.Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        ///  AES 解密
        /// </summary>
        /// <param name="str">明文（待解密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesDecrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = System.Convert.FromBase64String(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }

        public static string SerializeJsonString(object model, string GetKeyUrl)
        {
            string BodyJson = Newtonsoft.Json.JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver() });
            BodyJson = BodyJson.Replace("\r\n", "");
            string AesKey = GetResultJson(GetKeyUrl);
            string AesBodyJson = AesEncrypt(BodyJson, AesKey);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("json", AesBodyJson);
            string DictionaryJson = ConvertToBodyJson(dictionary);
            return DictionaryJson;
        }


        public static T ToJsonObject<T>(string src)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(src);
        }

        /// <summary>
        /// 去掉Json中的空值并返回实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static List<T> Json2Object<T>(string strJson)
        {
            JsonSerializerSettings jsonSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.DeserializeObject<List<T>>(strJson, jsonSetting);
        }
    }
}
