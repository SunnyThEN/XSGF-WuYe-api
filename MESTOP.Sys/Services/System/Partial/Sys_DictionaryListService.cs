using MESTOP.Core.BaseProvider;
using MESTOP.Core.Extensions.AutofacManager;
using MESTOP.Entity.DomainModels;
using System.Linq;
using MESTOP.Core.Extensions;
using System.Collections.Generic;
using MESTOP.Core.Enums;

namespace MESTOP.Sys.Services
{
    public partial class Sys_DictionaryListService
    {

        public override PageGridData<Sys_DictionaryList> GetPageData(PageDataOptions pageData)
        {
            base.OrderByExpression = x => new Dictionary<object, QueryOrderBy>() { {
                    x.OrderNo,QueryOrderBy.Desc
                },
                {
                    x.DicList_ID,QueryOrderBy.Asc
                }
            };
            return base.GetPageData(pageData);
        }
    }
}

