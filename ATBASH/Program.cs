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

        // warning system


    }
}