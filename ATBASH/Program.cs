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

        // warning system


    }
}