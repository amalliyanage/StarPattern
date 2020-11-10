using System;

namespace StarPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int space = 3;
            int max = 4;

            for(i = 0; i < max; i++){

                for(j = 0; j < space; j++){
                    Console.Write(" ");
                }
                for(j = 0; j<=i; j++){
                    Console.Write(" *");
                }
                
                Console.Write("\n");
                space--;
            }

            space = 1;
            max = max-1;

             for (i = max; i > 0; i--){
 
                for (j = 0; j < space; j++){
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++){
                    Console.Write(" *");
                }
 
                Console.Write("\n");
                space++;
            }
            Console.ReadLine();
        }
    }
}
