namespace ATBASH
{
    class Program
    {
        static void Main()
        {
            
        }

        // decrypting function

        // message analyzer

        // warning system / printer
        static bool Printer(Dictionary<string, string> msgDict)
        {
            if (msgDict == null)
            {
                Console.WriteLine("Message is empty, Please try again.");
                return false;
            }
            PrintWarningBanner(Convert.ToInt32(msgDict["score"]));
            Console.WriteLine($"Decrypted Message: {msgDict["Information"]}");
            Console.WriteLine($"Dangerous Words Found in Message: {msgDict["dangerous Words"]}");
            Console.WriteLine($"Amount of Dangerous Words Message: {msgDict["score"]}");
            return true;
        }

        //color printer
        static void PrintWarningBanner(int value)
        {
            string msg = "";
            if (value == 0) {
                Console.ForegroundColor = ConsoleColor.Green;
                msg = "ALL GOOD";
            }
            else if (value <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                msg = "! WARNING !";
            }
            else if (value <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                msg = "! DANGER !";
            }
            else if (value <= 15)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                msg = "! ULTRA ALERT !";
            }

            string FullMsg = $"###   {msg}   ###";
            string border = new string('#', FullMsg.Length);
            Console.WriteLine(border);
            Console.WriteLine(FullMsg);
            Console.WriteLine(border);
            Console.ResetColor();
        }
    }
}