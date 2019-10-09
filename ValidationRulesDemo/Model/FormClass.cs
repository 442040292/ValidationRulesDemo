using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationRulesDemo.Model
{
    public class FormClass : ObservableObject
    {

        private string _username;
        public string UserName
        {
            get => _username;
            set
            {
                Set(ref _username, value);
               //if (string.IsNullOrEmpty(value))
               // {
               //     throw new ApplicationException("Please enter a valid date.");
               // }
            }
        }


        private string _phone;
        public string Phone { get => _phone; set => Set(ref _phone, value); }
    }
}
