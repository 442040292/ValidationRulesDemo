using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ValidationRulesDemo
{
    public class ValidationRuleDependencyObject : DependencyObject
    {
        public static double GetAngle(DependencyObject obj)
        {
            return (double)obj.GetValue(AngleProperty);
        }

        public static void SetAngle(DependencyObject obj, double value)
        {
            obj.SetValue(AngleProperty, value);
        }

        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.RegisterAttached("Angle", typeof(double), typeof(ValidationRuleDependencyObject), new PropertyMetadata(0.0, OnAngleChanged));

        private static void OnAngleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var element = obj as TextBox;
            if (element != null)
            {
                Binding binding = new Binding();
                binding.ElementName = "";
                //binding.Path= "";
                binding.ValidationRules.Add(new NotNullValidationRule());
                //System.Windows.Controls.Validation.GetErrors(element)[0].ErrorContent.ToString();
            }
            //if (element != null)
            //{
            //    element.RenderTransformOrigin = new Point(0.5, 0.5);
            //    element.RenderTransform = new RotateTransform((double)e.NewValue);
            //}
        }
    }
}
