﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VMS.Portal.Test.Helper
{
    public static class ValidateHelper
    {
        static public bool ValidateObject(this object obj, out List<ValidationResult> messageResult)
        {
            var result = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(obj, new ValidationContext(obj, null, null), result, true);
            messageResult = result;
            return isValid;
        }
    }
}
