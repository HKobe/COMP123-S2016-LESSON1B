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
 * Version: 0.3 - Updated Comments for driver class Program 
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
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.WriteLine("/n ========================");
            Console.WriteLine("You Entered: " + username);
            return username;
        }
    }
}
