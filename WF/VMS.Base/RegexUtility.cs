using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WF.Base
{
    static public class RegexUtility
    {
        #region Initialization
        static private Regex _emailRegex;
        public static Regex EmailRegex
        {
            get
            {
                if (_emailRegex == null)
                {
                    _emailRegex = new Regex(EiuEmailPattern);
                }
                return _emailRegex;
            }
        }
        #endregion

        public const string EiuEmailPattern = @"^[a-zA-Z]+(.[a-zA-Z]+\w*)+@eiu.edu.vn$";
        public static bool IsValidEiuEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            return EmailRegex.IsMatch(email);
        }
    }
}
