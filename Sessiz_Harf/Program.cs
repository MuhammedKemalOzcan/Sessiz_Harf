namespace Sessiz_Harf
{
    internal class Program
    {
        //Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.
        public static bool IsConsonant(char c)
        {
            
            return "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(c);
        }
        public static void FindConsecutiveConsonant(string text)
        {
            bool isConsonant = false;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (IsConsonant(text[i]) && IsConsonant(text[i+1]))
                {
                    isConsonant = true;
                }
            }
            Console.WriteLine(isConsonant);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz:");
            string text = Console.ReadLine();

            FindConsecutiveConsonant(text);

        }
    }
}
