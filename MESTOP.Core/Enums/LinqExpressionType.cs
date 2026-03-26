using System;
using System.Collections.Generic;
using System.Text;

namespace MESTOP.Core.Enums
{
    public enum LinqExpressionType
    {
        Equal=0,//=
        NotEqual=1,//!=
        GreaterThan,//>
        LessThan,//<
        ThanOrEqual,//>=
        LessThanOrEqual,//<=
        In,
        Contains,//Contains
        Like,//Contains
        LikeStart,
        LikeEnd,
        NotLike,
        NotContains//NotContains
    }
}
