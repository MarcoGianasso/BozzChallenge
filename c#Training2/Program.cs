using System;

namespace c_Training2
{
    class Program
    {
        static void Main(string[] args)
        {
          
Console.Title="palindrome word and prime number checker";

string inverso="";

 Console.WriteLine("inserisci una parola: ");
 string parola= Console.ReadLine();
 int lunghezza = parola.Length;


    for(int j = lunghezza-1; j>=0; j--){

        inverso= inverso +parola[j];
    }

    if (inverso == parola  ){
        Console.WriteLine("La parola "+parola+" è palindroma.");
    } else {
        Console.WriteLine("La parola "+parola+" non è palindroma.");
    }



   



    Console.WriteLine("Inserisci un numero");  
            int number = Convert.ToInt32(Console.ReadLine());  



 int result = Check_Prime(number);  
            if (result == 0)  
            {  
                Console.WriteLine("{0} non è un numero primo", number);  
                Console.WriteLine("ah.... dimenticavo, il bozz è gay");
            }  
            else  
            {  
                 Console.WriteLine("{0} è un numero primo", number);  
                 Console.WriteLine("ah.... dimenticavo, il bozz è gay");
            }              
            Console.Read();  
            
        }   
  
        private static int Check_Prime(int number)  
       {  
            int i;  
            for (i = 2; i <= number - 1; i++)  
            {  
                if (number % i == 0)  
                {  
                    return 0;  
                }  
            }  
            if (i == number)  
            {  
                return 1;  
            }  
            return 0;  


   



     

    }
 }


}


    
        
    

