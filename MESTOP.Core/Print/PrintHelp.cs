using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace MESTOP.Core.Print
{
    namespace Umisky.BarcodePrint.Core
    {
        //第一种方法  使用时给打印机下达任务了 但是没有打印
        public class PrintHelpter
        {
            string dataFolderPath = System.Environment.CurrentDirectory;
            public static string GetDefaultPrinter()
            {
                PrintDocument print = new PrintDocument();
                string defaultName = print.PrinterSettings.PrinterName;//默认打印机名
                return defaultName;
            }

            /// <summary>
            /// 获取本地所有打印机
            /// </summary>
            /// <returns></returns>
            public static List<String> GetLocalPrinters()
            {
                List<String> printer_names = new List<String>();

                printer_names.Add(GetDefaultPrinter()); ///列表中的第一项就是默认打印机。

                foreach (String item in PrinterSettings.InstalledPrinters)
                {
                    Console.WriteLine(item);
                    if (!printer_names.Contains(item))
                    {
                        printer_names.Add(item);
                        Console.WriteLine("add:" + item);
                    }

                }
                return printer_names;
            }
            /// <summary>
            /// 内容打印
            /// </summary>
            /// <param name="szPrinterName">打印机名称</param>
            /// <param name="szString">打印的SBPL指令</param>
            /// <returns></returns>
            public bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                int dwCount;
                dwCount = szString.Length;
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }

            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, int pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "labelprint";
                di.pDataType = "RAW";

                // Open the printer.
                if (OpenPrinter(szPrinterName, out hPrinter, 0))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }
            public bool labelPrintConfigFile()
            {
                return File.Exists(dataFolderPath + "\\print.prn");
            }


            ///
            public void print(string printerName, string textTEST)
            {
                PrintHelpter printHelpter = new PrintHelpter();

                string[] textTESTs = { "textTEST", "textTEST", textTEST, "" };

                string[][] printVaule = { textTESTs };

                string[] infile = null;
                try
                {
                    infile = File.ReadAllLines(dataFolderPath + "\\print.prn", Encoding.GetEncoding("UTF-8"));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                ///<内容替换
                for (int i = 0; i < infile.Length; i++)
                {
                    for (int k = 0; k < printVaule.Length; k++)
                    {
                        string[] temp = printVaule[k];
                        for (int j = 0; j < 2; j++)
                        {
                            int index = infile[i].IndexOf(temp[j]);
                            if (index > -1)
                            {
                                Console.WriteLine("data:" + infile[i]);
                                if (j == 0)
                                {
                                    infile[i] = infile[i].Replace(temp[j], temp[2]);
                                }
                                else
                                {
                                    infile[i] = infile[i].Replace(temp[j], temp[3] + temp[2]);
                                }

                                Console.WriteLine(infile[i]);
                                break;

                            }
                        }
                    }

                }


                string printString = "";
                for (int i = 0; i < infile.Length; i++)
                {
                    printString += infile[i] + "\n";
                }

                printHelpter.SendStringToPrinter(printerName, printString);
            }
        }
    }
}
