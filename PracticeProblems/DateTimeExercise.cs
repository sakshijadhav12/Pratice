using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class DateTimeExercise
    {
                //Write a C# Sharp program to extract the Date property and display the DateTime
                //value in the formatted output.

                //Expected Output:

                //Complete date: 6/8/2016 11:49:00 AM
                //Short Date: 6/8/2016                                                             
                //Display date using 24-hour clock format:                                         
                //6/8/2016 12:00 AM                                                                
                //06/08/2016 00:00 

        public void DisplayDateTime()
        {
            DateTime dateTimeValue = new DateTime(2016, 6, 8, 11, 49, 0);
            Console.WriteLine("Complete date: " + dateTimeValue.ToString("M/d/yyyy h:mm:ss tt"));
            Console.WriteLine("Short Date: " + dateTimeValue.ToString("M/d/yyyy"));
            Console.WriteLine("Display date using 24-hour clock format:");
            Console.WriteLine(dateTimeValue.ToString("M/d/yyyy h:mm:ss tt"));
            Console.WriteLine(dateTimeValue.ToString("MM/dd/yyyy HH:mm"));
        }
       // Write a C# Sharp program to add whole and fractional values to a date and time.
       public void AddValuestoDateAndTime()
        {
            double[] hours = {.0665553, .16667,  .33333, .5, .66667, 1, 2,
                        29, 30, 31, 90, 365};
            DateTime dateValue = new DateTime(2016, 8, 16, 12, 0, 0);

            foreach (double hour in hours)
            {
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour,
                                  dateValue.AddHours(hour));
            }
        }

        //Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent.
        //This is done using the specified array of formats, culture-specific format information, and style.

        public void Conversion()
        {
 
            string dateString = "2023-12-07 14:30:00";
            string[] formats = { "yyyy-MM-dd HH:mm:ss", "yyyy/MM/dd HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };
            CultureInfo culture = CultureInfo.InvariantCulture;
            DateTimeStyles style = DateTimeStyles.None;
            if (DateTime.TryParseExact(dateString, formats, culture, style, out DateTime result))
            {
                Console.WriteLine("Parsed DateTime: " + result);
            }
            else
            {
                Console.WriteLine("Failed to parse the input string.");
            }
        }

        //Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent.
       // Attempting to parse strings using en-US culture.


        public void DateTimeEqivalent()
        {
            string[] dateStrings = {
            "05/01/2016 14:57:32.8",
            "2016-05-01 14:57:32.8",
            "2016-05-01T14:57:32.8375298-04:00",
            "5/01/2015",
            "5/01/2015 14:57:32.80 -07:00",
            "1 May 2015 2:57:32.8 PM",
            "16-05-2016 1:00:32 PM",
            "Fri, 15 May 2016 20:10:57 GMT"
        };

            CultureInfo culture = new CultureInfo("en-US");
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, culture, DateTimeStyles.None, out DateTime result))
                {
                    Console.WriteLine($"Converted '{dateString}' to {result} ({result.Kind}).");
                }
                else
                {
                    Console.WriteLine($"Unable to parse '{dateString}'.");
                }
            }
        }
    }
}

    

