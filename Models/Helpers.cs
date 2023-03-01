using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GearInsight.Models
{
    public class Helpers
    {
        public static string GetInputFromUser(string prompt)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.Write("Input can't be empty, please enter a valid value: ");
                input = Console.ReadLine();
            }
            return input.ToLower();
        }

        public static int GetIntFromUser(string prompt)
        {
            Console.Write(prompt);
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input, please enter a valid number: ");
            }
            return input;
        }
        public static string GetEnchantments(string value)
        {
            string enchant = value.Substring(value.IndexOf(" ") + 1, value.IndexOf("|"));
            enchant = enchant.Substring(0, enchant.IndexOf("|") - 1);
            return enchant;
        }

        public static string ExtractValue(string input)
        {
            string pattern = @"\bValue\s*=\s*(\d+)\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
        public static string FirstLetterCapital(string name)
        {
            var value = name.Substring(0, 1);
            value = value.ToUpper();
            value = value + name.Substring(1, name.Length - 1);
            return value;
        }
        public static int ExtractRatingFromStats(string input)
        {
            string pattern = @"\bRating\s*=\s*(\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success)
            {
                return int.Parse(match.Groups[1].Value);
            }
            else
            {
                return 0;
            }
        }

        public static double? ExtractPercentFromStats(string input)
        {
            string pattern = @"\bValue\s*=\s*(\d+(?:,\d{3})*(?:\.\d+)?)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success)
            {
                return double.Parse(match.Groups[1].Value); //.Replace(",", "")
            }
            else
            {
                return null;
            }
        }

    }
}
