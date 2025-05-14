namespace ATBASH
{
    class Program
    {
        static void Main()
        {
            
        }

        string Decoder(string EncryptedText)
        {
            string DecryptedText = " ";
            Dictionary<char, char> Atbash = new Dictionary<char, char>
    {
        { 'a', 'z' },
        { 'b', 'y' },
        { 'c', 'x' },
        { 'd', 'w' },
        { 'e', 'v' },
        { 'f', 'u' },
        { 'g', 't' },
        { 'h', 's' },
        { 'i', 'r' },
        { 'j', 'q' },
        { 'k', 'p' },
        { 'l', 'o' },
        { 'm', 'n' },
        { 'n', 'm' },
        { 'o', 'l' },
        { 'p', 'k' },
        { 'q', 'j' },
        { 'r', 'i' },
        { 's', 'h' },
        { 't', 'g' },
        { 'u', 'f' },
        { 'v', 'e' },
        { 'w', 'd' },
        { 'x', 'c' },
        { 'y', 'b' },
        { 'z', 'a' }
    };

            foreach (char i in EncryptedText.ToLower())
            {
                if (Atbash.ContainsKey(i))
                {
                    DecryptedText += Atbash[i];
                }
                else
                {
                    DecryptedText += i;
                }
            }
            return DecryptedText;
        }


        // message analyzer
        Dictionary<string, string> RiskCalculation(string EnemyInformation)
        {
            string[] dangerousWords = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string[] arrEnemyInformatin = EnemyInformation.Split(" ");
            List<string> dangerousWordsUsed = new List<string>();
            int score = 0;
            foreach (string word in arrEnemyInformatin)
            {
                if (dangerousWords.Contains(word))
                {
                    if (!(dangerousWordsUsed.Contains(word)))
                    {
                        dangerousWordsUsed.Add(word);

                    }
                    else
                    {

                    }
                    score++;
                }
            }
            Dictionary<string, string> InformationFromTheFile = new Dictionary<string, string>
        { { "Information" , EnemyInformation}, {"dangerous Words" , ToString(dangerousWordsUsed) } , {"score" , $"{score}" }  };
            return InformationFromTheFile;
        }
        string ToString(List<string> list)
        {
            string Words = "";
            foreach (string word in list)
            {
                Words += $" {word}";
            }
            return Words;
        }

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