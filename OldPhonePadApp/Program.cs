namespace Iron.CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Welcome to OldPhonePas application!

Here is an old phone keypad with alphabetical letters, a
backspace key, and a send button.

Each button has a number to identify it and pressing a button
multiple times will cycle through the letters on it allowing
each button to represent more than one letter.

For example, pressing 2 once will return 'A' but pressing twice
in succession will return 'B'.

You must pause for a second in order to type two characters from the same
button after each other: “222 2 22” -> “CAB”.");

            Console.Write($"{Environment.NewLine}Enter input string or type 'exit':");
            string input;
            while (!(input = Console.ReadLine()).Equals("exit"))
            {
                try
                {
                    var output = OldPhonePad.Convert(input);
                    Console.WriteLine($"{new string(' ', 27)}input:'{input}' => output:'{output}'");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Input string error: {e.Message}");
                }
                
                Console.Write($"{Environment.NewLine}Enter input string or type 'exit':");
            }
            Console.WriteLine("exit");
        }
    }
}