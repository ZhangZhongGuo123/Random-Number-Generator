using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Randon_Number_Generator
{
    public static class NumericTextBoxBehavior
    {
        public static readonly DependencyProperty AllowOnlyNumbersProperty =
            DependencyProperty.RegisterAttached("AllowOnlyNumbers", typeof(bool), typeof(NumericTextBoxBehavior),
                new FrameworkPropertyMetadata(false, OnAllowOnlyNumbersChanged));

        public static bool GetAllowOnlyNumbers(DependencyObject obj)
        {
            return (bool)obj.GetValue(AllowOnlyNumbersProperty);
        }

        public static void SetAllowOnlyNumbers(DependencyObject obj, bool value)
        {
            obj.SetValue(AllowOnlyNumbersProperty, value);
        }

        private static void OnAllowOnlyNumbersChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                if ((bool)e.NewValue)
                {
                    textBox.PreviewTextInput += TextBox_PreviewTextInput;
                    DataObject.AddPastingHandler(textBox, PastingEventHandler);
                    textBox.KeyDown += TextBox_KeyDown;
                }
                else
                {
                    textBox.PreviewTextInput -= TextBox_PreviewTextInput;
                    DataObject.RemovePastingHandler(textBox, PastingEventHandler);
                    textBox.KeyDown -= TextBox_KeyDown;
                }
            }
        }

        private static void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = !IsNumericInput(e.Text);
        }

        private static void PastingEventHandler(object sender, DataObjectPastingEventArgs e)
        {
            var textBox = sender as TextBox;
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!IsNumericInput(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private static void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private static bool IsNumericInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
