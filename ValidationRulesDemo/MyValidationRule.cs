using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidationRulesDemo
{
    public class MyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (value?.ToString() != "2")
            {
                return new ValidationResult(false, value?.ToString() + "值必须为2");
            }
            return new ValidationResult(true, null);
        }
    }
}
