using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    //Created a translator class to create objects. HP
    //Kept the main public class empty to use Unit Testing. HP
    class Translator
    {
        //Got rid of all static methods. HP
        public string UserInput(string userInput) //Changed this to string method called UserInput HP     
        {
            //string userInput = GetInput("Please input a word or sentence to translate to pig Latin");
            //comment out to resolve having to get console input
            string[] sentence = userInput.Split(' '); //if string has multiple words separated by space HP                                                   
                                                      //we'll split it into array of strings (words) HP
            string translation = "placeholder";
            foreach (string aWord in sentence) //create foreach to resolve string that is a sentence HP
            {
                translation = ToPigLatin(aWord);
                //Console.WriteLine($"{translation} "); //Prints the sentence HP               
            }
            return translation;
        }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public bool IsVowel(char c)
        {
            //completely changed the IsVowel method.
            //Using loop to iterate through the logic.
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //return c.ToString() == vowels.ToString();
            bool vow = false;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (c.Equals(vowels[i]))
                {
                    vow = true;
                    break;
                }
                else
                {
                    vow = false;
                }
            }
            return vow;
        }

        public string ToPigLatin(string word) //Could not place for loop in this method. Not able to return a value. HP
        {                        
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }
            }

            bool noVowels = true;
            foreach (char letter in word) //this loop determines if every letter of the word has a vowel HP
            {
                if (IsVowel(letter))
                {
                    noVowels = false; //IsVowel checks for vowels, if returns true enter block HP
                                        //if there are vowels then noVowels is false HP
                }
            }

            if (noVowels) //if noVowels is true (there are no vowels), then enter block HP
            {
                return word; //print word as is. HP
            }

            char firstLetter = word[0]; //first index of word HP
            string output = "placeholder"; //"placeholder" (this string will be overwritten) HP
            if (IsVowel(firstLetter) == true) //if the first letter is a vowel HP
            {
                output = word + "way"; //add "ay" to the end of the word and store in variable output HP
                                        //changed to "way" if word starts with vowel HP
            }
            else
            {
                int vowelIndex = 0; //changed vowelIndex value to 0 (was -1). HP
                                    //Handle going through all the consonants
                for (int i = 0; i < word.Length; i++) //was i <= word.Length HP
                {
                    if (IsVowel(word[i]) == true) //if the first letter of the 
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.Substring(vowelIndex); //word.Substring(vowelIndex + 1) = ck
                                                            //word.Substring(vowelIndex) will include every
                                                            //char after vowelIndex of the word (eck)
                string postFix = word.Substring(0, vowelIndex); //bringing the consanants to the end of the word
                                                                //from index 0 to vowelIndex, excluding index
                output = sub + postFix + "ay";
            }
            return output;
                    
        }
        
    }
}
