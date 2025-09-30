using System;
using System.Threading;

class Program {
        static void Main() {
            Console.WriteLine("Write some text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Write how much time delay to keep between showing characters in miliseconds(ms): ");
            string input = Console.ReadLine();

            int sleepTime;
            if (!int.TryParse(input, out sleepTime)) {
                Console.WriteLine("Invalid input! Using default delay of 500ms");
                sleepTime = 500;
            }


        
            for(int i = 0; i < text.Length; i++) {
                Console.WriteLine(text[i]);
                Thread.Sleep(sleepTime);
        }
        Console.ReadKey();
        Console.WriteLine("!code execution success!");
    }
}

