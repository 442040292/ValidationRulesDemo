using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidationRulesDemo
{

    public class EnumValidationRule : ValidationRule
    {
        private string _enumClass;
        private string _errorMessage;

        public string EnumClass
        {
            get { return "Allan.WPFBinding.ValidationDemo." + _enumClass; }
            set { _enumClass = value; }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            ValidationResult result = new ValidationResult(true, null);
            string inputString = (value ?? string.Empty).ToString();

            Type type = Type.GetType(EnumClass);
            if (string.IsNullOrEmpty(inputString) /*|| !ValidateInput(type, inputString)*/)
            {
                result = new ValidationResult(false, this.ErrorMessage);
            }
            return result;
        }

    }
}
