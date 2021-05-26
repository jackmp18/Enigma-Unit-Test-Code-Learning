using System;

namespace enigma
{
    class Enigma
    {
        public void encript(string message)
        {

        }
        public void decript(string message)
        {

        }
        static void Main(string[] args)
        {
            Enigma em = new Enigma();
            string user, message, code;
            for (int i = 0; i < 100; i++) {
                Console.WriteLine("Hello would you like to;");
                Console.WriteLine("A) Encript?");
                Console.WriteLine("B) Decript?");
                Console.WriteLine("C) Exit");
                user = Console.ReadLine();
                if (user == "A")
                {
                    Console.WriteLine("Enter your message");
                    message = Console.ReadLine();
                    em.encript(message);
                }else if(user == "B")
                {
                    Console.WriteLine("Enter your code");
                    code = Console.ReadLine();
                    decript();
                }
                else if (user == "C")
                {
                    return;
                } else
                {
                    Console.WriteLine("try agian");
                }
            }
        }
    }
}
