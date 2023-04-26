using System;

namespace csharp_fundamentals_primitive_types.Main
{
    public class Core
    {
        public Core() { }

        public static int numOne = 8;
        public static int numTwo = 16;
        public static int numThree = 32;


        // 1. Change the value of the member below to be the result of adding numOne and numTwo together
        public int numOnePlusTwo = numOne + numTwo;


        // 2. Change the value of the member below to be the result of multiplying numThree by numTwo
        public int numThreeTimesNumTwo = numThree * numTwo;


        // 3. Change the value of the member below to be the result of dividing numThree by numOne
        public int numThreeDividedByNumOne = numThree / numOne;


        // 4. Change the value of the member below to be the result of subtracting numOne from numThree
        public int numThreeMinusNumOne = numThree - numOne;


        // 5. Change the value of the member below to be the sum of numOne, numTwo and numThree
        public int sum = numOne + numTwo + numThree;


        // 6. Change the value of the member below to be the sum of numOne, numTwo and numThree divided by numOne
        public int numBytes = (numOne + numTwo + numThree) / numOne;


        // 7. Create a public static char member named lastLetter containing the last letter of the English alphabet
        public  char lastLetter = 'Z';


        // 8. Create a public static float member named pi that contains the value of pi to two decimal places
        public float pi = 3.14f;


        // 9. Create a public static double member named piD that contains the value of pi to 5 decimal places
        public  double piD = 3.14159d;


        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string firstName = "Jane";
        public static string lastName = "Smith";

        // 10. Create a public static member named fullName that contains the value of firstName and lastName concatenated together with a space in between
        public  string fullName = $"{firstName} {lastName}";


        // 11. Fix the line below so that tenthLetter contains the tenth letter in the alphabet member above.
        public char tenthLetter = alphabet.ToCharArray().ElementAtOrDefault(9);


        // 12. Create a public static string member named lowerAlphabet that contains the value of the alphabet member in all lower case characters
        // If you need help, look through the available String methods to find a relevant one here: https://www.w3schools.com/cs/cs_strings.php
        public string lowerAlphabet = alphabet.ToLower();


        // 13. Create a public static integer member named alphabetLength that contains the number of characters that exist in the alphabet member
        // Use the documentation linked above if you need help
        public int alphabetLength = alphabet.Length;


        // 14. Create a public static integer member named remainder that contains the remainder of dividing 15 by 8
        public int remainder = 15 % 8;
    }

}