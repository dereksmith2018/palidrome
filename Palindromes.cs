using System;

public class Program
{
   public  static void Check(string input)
  {
   char[] firstArray = input.ToCharArray();
   string reverse = String.Empty;
   for (int i = firstArray.Length - 1; i > -1; i--)
  {
       reverse += firstArray[i];
  }
   return reverse;
}
   if (ArrA[i] == ArrB[i]){
        Console.WriteLine( "AAAAAA" );
        //return  true;
  }
  else {
    Console.WriteLine( "BBBBB" );
    //return false;
      }
    }


  public static void Main()
  {
    Console.WriteLine( "Write Something" );
    string userInput =Console.ReadLine();

    Check(userInput);
    //Console.WriteLine(Check(userInput));

      }
    }
