using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    class Regexes
    {
        //check if phone number is matches pattern--  (123) 456-7891
        public static bool IsValidPhoneNumber(string str)
        {
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";
            Regex regex = new Regex(pattern);
            //Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            Match match = Regex.Match(str, pattern);
            return match.Success;
        }

        //replace all non letter characters using Regex
        //using System.Text.RegularExpressions;
        public static string LettersOnly(string str)
        {
            string result = Regex.Replace(str, "[^a-zA-Z]", "");
            return result;
        }

        //replace vowels with regular expression
        public static string ReplaceVowels(string str, string ch)
        {
            string result = Regex.Replace(str, "[aeuio]", ch);
            return result;
        }

        /* string pattern = @"
        ^                  # From Beginning of line
        (?:\(?)            # Match but don't capture optional (
        (?<AreaCode>\d{3}) # 3 digit area code
        (?:[\).\s]?)       # Optional ) or . or space
        (?<Prefix>\d{3})   # Prefix
        (?:[-\.\s]?)       # optional - or . or space
        (?<Suffix>\d{4})   # Suffix
        (?!\d)             # Fail if eleventh number found";
        The above pattern just looks for 10 numbers and ignores any filler characters such as a ( or a dash - or a space or a tab or even a .. Examples are

        (555)555-5555 (OK)
        5555555555 (ok)
        555 555 5555(ok)
        555.555.5555 (ok)
        55555555556 (not ok - match failure - too many digits)
        123.456.789 (failure) */

        //Regex for a 5 consecutive digits [/d{5}]

    }
}
