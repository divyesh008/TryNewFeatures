using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace NewControlsDemo.Converters
{
    public class StringToFormattedTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value == null)
                {
                    return new FormattedString();
                }
                else
                {
                    var val = (string)value;
                    string pattern = "D";

                    var fText = new FormattedString();
                    string[] substrings = Regex.Split(val, pattern);

                    /* String will be splitted in 3 parts
                       [0] Hello
                       [1] D [Bold]
                       [2] ev! How are you?
                    */
                    if (substrings != null && substrings.Count() >= 0)
                    {
                        fText.Spans.Add(new Span { Text = substrings[0], FontFamily = "RobotoRegular" });
                        fText.Spans.Add(new Span { Text = "D", FontFamily = "RobotoBold" });
                        fText.Spans.Add(new Span { Text = substrings[1], FontFamily = "RobotoRegular" });
                    }
                    
                    Debug.WriteLine($"Final Formatted Text - {fText}");

                    return fText;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception - {ex.Message}");
            }

            return (string)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
