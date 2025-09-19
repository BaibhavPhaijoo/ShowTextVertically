using System;
using System.Threading;

class Program {
        static void Main() {
            Console.WriteLine("Write some text: ");
            string text = Console.ReadLine();
        
            for(int i = 0; i < text.Length; i++) {
                Console.WriteLine(text[i]);
                Thread.Sleep(350);
        }
        Console.ReadKey();
    }
}
