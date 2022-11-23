namespace _23_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine().ToLowerInvariant();
            
            
            if (str[0] != ' ')
                {
                    Console.Write(char.ToUpper(str[0]));
                }

            for (int i = 1; i < str.Length ; i++)
            {

                if (str[i - 1] == ' ' && str[i] != ' ')
                {

                    Console.Write(char.ToUpper(str[i]) );
                }
                else
                {
                    Console.Write(str[i]);
                }
            }

        }
    }
}