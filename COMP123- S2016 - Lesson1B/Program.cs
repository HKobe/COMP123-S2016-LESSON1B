using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Author: Hassan Kobeissi
 * Date Created: Friday, 13th, 2016
 * Date Modified: Friday, 13th, 2016
 * StudentID: 300847239
 * Description: This version demonstrates Github and Version Control best practices. We also explore Unit Testing.
 * Version: 0.4 - Extracted OutputStringToConsole from GetUsername method
 */

namespace COMP123__S2016___Lesson1B
{
    /*
     This is the driver class for our program
     * @class Program
     * @constructor Main
     */
    class Program
    {
        /**
         Main method for class Program
         * @Param {string[]} args
         */
        static void Main(string[] args)
        {
            GetUsername();
        }
        /*
         This methods reads username from the console
         * @methodGetUsername
         * @return {string} Username
         */
        public static string GetUsername()
        {
            //Initialize Variables
            string username = "";
            OutputStringToConsole("Enter Username: ", false);
            {
            username = Console.ReadLine();
            }

            Console.WriteLine("\n ======================== \n ");
            Console.WriteLine("You Entered: " + username + "\n");
            return username;
        }
        /*This method writes a string to the console. Parameers allow the user to choose to add a newLine Char
         *@method OutputStringToConsole
         * @param {string} outputString
         * @return {string} outputString
         */

        private static string NewMethod(string username)
        {
            username = Console.ReadLine();
            return username;
        }
        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if(hasNewLine)
            {
                Console.WriteLine(outputString);
            } else 
            {
                Console.Write(outputString);
            }
            return outputString;
        }
    }
}
