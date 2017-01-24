using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.CustomValidation
{
    /// <summary>
    /// CPR number validation attribute.
    /// </summary>
    public class CPRAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Boolean status = false;

            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                string cprString = value.ToString();
                if (cprString.Length == 10)
                {
                    status = true;
                }
            }

            return status;
        }
    }
}