using System.Text;
using System.Text.RegularExpressions;

namespace Iron.CodeChallenge
{
    // Implements OldPhonePad convertation behavior
    public class OldPhonePad 
    {
        private static readonly string[] keyboard = new string[] 
            {
                // 0 - to reserve zero index in array and simplify array usage
                string.Empty,
                "&'(",  // 1
                "ABC",  // 2
                "DEF",  // 3
                "GHI",  // 4
                "JKL",  // 5
                "MNO",  // 6
                "PQRS", // 7
                "TUV",  // 8
                "WXYZ"  // 9
            };
        public static String Convert(string input)
        {
            // validate input for null
            if(input is null) throw new ArgumentNullException("input");

            // validate input for '1-9', '*', ' ' and '#' at the en
            if(!Regex.IsMatch(input, @"^([1-9*\s])*#$")) throw new ArgumentException("Wrong format. '1-9', '*', ' ' are expected folowing '#' symbol at the end", "input");
            // explanation:
            // ^        - line start
            // [1-9*\s] - '1-9' or '*' or ' '
            // #        - '#'
            // $        - eol

            // find all key actions in the input
            var keyActions = Regex.Matches(input, @"([1-9])\1{0,}|([*])");
            // explanation:
            // [1-9]    - '1-9'
            // \1       - matches the same text as most recently matched by the 1st capturing group
            // {0,}     - matches the previous token between zero and unlimited times, as many times as possible
            // |        - or
            // [*]      - Match a single '*'


            var output = new StringBuilder();

            // iterate all key actions
            foreach(var keyAction in keyActions)
            {
                var keyValue = keyAction.ToString();
                if (keyValue.Equals("*"))
                {
                    // remove previous symbol from output if length > 0
                    if (output.Length > 0) output.Remove(output.Length - 1, 1);
                }
                else
                {
                    // convert keyAction to character and append to the output
                    var keyIndex = byte.Parse(keyValue[0].ToString());
                    var key = keyboard[keyIndex];

                    var pressCount = keyValue.Length;

                    // Compute the remainder to handle "2222" => "A" cases 
                    // (this assumption is missing in requirements)
                    var charIndex = (pressCount - 1) % key.Length;

                    // add character to the end of output
                    output.Append(key[charIndex]);
                }
            }

            return output.ToString();
        }
    }
}