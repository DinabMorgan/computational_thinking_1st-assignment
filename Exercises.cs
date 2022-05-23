namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number.");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            Console.WriteLine("Please enter another number.");
            string input1 = Console.ReadLine();
            int num1 = Int32.Parse(input1);


            if (num != num1)
            {
                Console.WriteLine("These numbers are not equal.");
            }
            else
            {
                Console.WriteLine("Great job, the numbers are equal!");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            Console.WriteLine("Please enter a number.");
            string even = Console.ReadLine();
            int notOdd = Int32.Parse(even);

            if (notOdd % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }

            Console.WriteLine("Thank you for playing!");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            Console.WriteLine("Please enter a letter.");
            string letterResponse = Console.ReadLine();

            switch (letterResponse)
            {
                case "A":
                case "a":
                case "E":
                case "e":
                case "I":
                case "i":
                case "O":
                case "o":
                case "U":
                case "u":
                    Console.WriteLine("You wrote a vowel!");
                    break;
                case "Y":
                case "y":
                    Console.WriteLine("Some consider this a vowel, while others do not.");
                    break;
                default:
                    Console.WriteLine("You wrote a consonant!");
                    break;
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number.");
            string firstNumber = Console.ReadLine();
            int numberFirst = Int32.Parse(firstNumber);

            Console.WriteLine("Please enter another number.");
            string secondNumber = Console.ReadLine();
            int numberSecond = Int32.Parse(secondNumber);

            Console.WriteLine("Please enter a third number.");
            string thirdNumber = Console.ReadLine();
            int numberThird = Int32.Parse(thirdNumber);

            if (numberFirst >= numberSecond && numberFirst >= numberThird)
            {
                Console.WriteLine("The biggest number is: " + numberFirst);
            }
            else if (numberSecond >= numberThird && numberSecond >= numberFirst)
            {
                Console.WriteLine("The biggest number is: " + numberSecond);
            }
            else if (numberThird >= numberFirst && numberThird >= numberSecond)
            {
                Console.WriteLine("The biggest number is: " + numberThird);
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here


            Console.WriteLine("Please enter a number!");
            string dNumber = Console.ReadLine();
            int three = Int32.Parse(dNumber);

            if (three % 3 == 0)
            {
                Console.WriteLine("Your number is divisible by 3!");

            }
            else
            {
                Console.WriteLine("Your number is not divisible by 3!");
            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            int sum = 13 * 4;
            Console.WriteLine(" Mike and his friends need to pay $ "+ sum);

            Console.WriteLine("Number of diners?");
            string diners = Console.ReadLine();
            int num = Int32.Parse(diners);

            Console.WriteLine("How much is each diner paying?");
            string payment = Console.ReadLine();
            int num2 = Int32.Parse(payment);

            int sum2 = num * num2;
            Console.WriteLine("Total cost of bill $" + sum2);


            if (sum2 >= 50)
            {
                Console.WriteLine("Congratulations! You get 10% off your total bill!");
                int num3 = sum2 * 10 / 100;
                int billWithDiscount = sum2 - num3;
                Console.WriteLine("$ " + billWithDiscount + " is your new bill total.");
                    

            }
            else
            {
                Console.WriteLine("please pay, $ " + sum2);
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here



            Console.WriteLine("Please enter your age.");
            string response = Console.ReadLine();
            int age = Int32.Parse(response);

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (age == 3 || age == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the man (or woman)");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years (like the David Bowie song!");
            }
            else if (age <= -1 || age >= 101)
            {
                Console.WriteLine("This program is for humans!");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.


            Console.WriteLine(" Please write out a number 1-10");
            string nResponse = Console.ReadLine();

            switch (nResponse)
            {
                case "one":
                    Console.WriteLine("You entered the number 1");
                    break;
                case "two":
                    Console.WriteLine("You entered the number 2");
                    break;
                case "three":
                    Console.WriteLine("You entered the number 3");
                    break;
                case "four":
                    Console.WriteLine("You entered the number 4");
                    break;
                case "five":
                    Console.WriteLine("You entered the number 5");
                    break;
                case "six":
                    Console.WriteLine("You entered the number 6");
                    break;
                case "seven":
                    Console.WriteLine("You entered the number 7");
                    break;
                case "eight":
                    Console.WriteLine("You entered the number 8");
                    break;
                case "nine":
                    Console.WriteLine("You entered the number 9");
                    break;
                case "ten":
                    Console.WriteLine("You entered the number 10");
                    break;
                default:
                    Console.WriteLine("You didn't write out a number! Oh no!!");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.WriteLine("Please enter a name.");
            string nameOne = Console.ReadLine();
            int nameOneLength = nameOne.Length;

            Console.WriteLine("Please enter another name.");
            string nameTwo = Console.ReadLine();
            int nameTwoLength = nameTwo.Length;


            if (nameOneLength == nameTwoLength)
            {

                Console.WriteLine("Both names are the same length.");
            }
            else if (nameOneLength >= nameTwoLength)
            {

                Console.WriteLine(nameOne + " is the longer name.");
            }
            else
            {
                Console.WriteLine(nameTwo + " is the longer name.");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."




            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a name.");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please enter a name.");
            string name2 = Console.ReadLine();

            if (name1 == name2)
            {
                Console.WriteLine("The names are the same!");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }
            {
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            

                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("Hello " + firstName + "!  Where were you born? ");
                string place = Console.ReadLine();
                Console.WriteLine("Hey " + firstName + "! You were born in " + place + ".");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }
    
    }
}
