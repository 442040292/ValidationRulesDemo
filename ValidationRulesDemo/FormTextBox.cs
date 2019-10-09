using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ValidationRulesDemo
{
    public class FormTextBox : TextBox
    {


        public FormTextBox() : base()
        {
            TextChanged += FormTextBox_TextChanged;
        }

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(FormTextBox), new PropertyMetadata(null));


        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        // Using a DependencyProperty as the backing store for IconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(FormTextBox), new PropertyMetadata(null));

        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        // Using a DependencyProperty as the backing store for IconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(FormTextBox), new PropertyMetadata(null));

        public double IconOpacity
        {
            get { return (double)GetValue(IconOpacityProperty); }
            set { SetValue(IconOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconOpacity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconOpacityProperty =
            DependencyProperty.Register("IconOpacity", typeof(double), typeof(FormTextBox), new PropertyMetadata(0.3D));

        public string WaterText
        {
            get { return (string)GetValue(WaterTextProperty); }
            set { SetValue(WaterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterTextProperty =
            DependencyProperty.Register("WaterText", typeof(string), typeof(FormTextBox), new PropertyMetadata(""));


        public ValidationRule MyValidationRule
        {
            get { return (ValidationRule)GetValue(MyValidationRuleProperty); }
            set { SetValue(MyValidationRuleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyValidationRule.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyValidationRuleProperty =
            DependencyProperty.Register("MyValidationRule", typeof(ValidationRule), typeof(FormTextBox), new PropertyMetadata(null));


        public bool ValidationHasError
        {
            get { return (bool)GetValue(ValidationHasErrorProperty); }
            set { SetValue(ValidationHasErrorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValidationHasError.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValidationHasErrorProperty =
            DependencyProperty.Register("ValidationHasError", typeof(bool), typeof(FormTextBox), new PropertyMetadata(false));

        public string ValidationErrorMessage
        {
            get { return (string)GetValue(ValidationErrorMessageProperty); }
            set { SetValue(ValidationErrorMessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValidationErrorMessage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValidationErrorMessageProperty =
            DependencyProperty.Register("ValidationErrorMessage", typeof(string), typeof(FormTextBox), new PropertyMetadata(""));



        public double ErrorMessageFontSize
        {
            get { return (double)GetValue(ErrorMessageFontSizeProperty); }
            set { SetValue(ErrorMessageFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ErrorMessageFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ErrorMessageFontSizeProperty =
            DependencyProperty.Register("ErrorMessageFontSize", typeof(double), typeof(FormTextBox), new PropertyMetadata(12D));


        private void FormTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = MyValidationRule?.Validate(this.Text, System.Globalization.CultureInfo.CurrentCulture);
            ValidationHasError = !result.IsValid;
            ValidationErrorMessage = result.ErrorContent?.ToString();
        }


        public bool ValidationCheckError()
        {
            var result = MyValidationRule?.Validate(this.Text, System.Globalization.CultureInfo.CurrentCulture);
            ValidationHasError = !result.IsValid;
            ValidationErrorMessage = result.ErrorContent?.ToString();
            return ValidationHasError;
        }
    }
}
