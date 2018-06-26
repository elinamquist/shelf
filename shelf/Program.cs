

//Author:Elinam Quist
//Author Url:
//Version:1.0.0
//Application:Shelf
//year:2018
//License URI: http://www.gnu.org/licenses/gpl-2.0.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shelf
{
    class Program
    {
       
        //Gives an introduction to the app.
        public void app_intro()
        {
            Console.WriteLine("");
          

            Console.WriteLine("\t \t \t **************************************************************\t \t \t");
            Console.WriteLine("\t \t \t \t \t \t Welcome to SHELF\t \t \t \t \t \t");
            Console.WriteLine("\t \t \t **************************************************************\t \t \t");
            Console.WriteLine("");

            Console.WriteLine(" \t \"SHELF\" is a program written by Elinam Quist to help students to easily  locate a book on the libray shelf.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Enter Book Category or press \'1' to display available categories : ");
        }
           
        public class MainApp
        {
            //Available book categories
            public string[] categories ={
                              "mechanical engineering",
                              "architecture",
                              "transportation",
                              "engineering",
                              "computing",
                              "statistics",
                              "zoology",
                              "biology",
                              "physics",
                              "christian theology",
                              "languages",
                              "physiology",
                              "nutrition",
                              "medicine",
                              "programing",
                              "software enginering",
                              "computing",
                              "socialogy",
                              "criminology",
                              "English",
                              "Mathematics",
                              "Computer Science",
                              "Engeneering",
                              "Magazine",
                              "French",
                              "Social Studies",
                              "Religion",
                              "History",
                              "Electronic",
                              "Programing",
                              "Database",
                              "Computer",
                              "arts",
                              "science",
                              "photography",
                              "music",
                              "fashion"
                          };
            // creates a method to print out All book categories from the categories array.
            public void printCategories()
            {
                var sortedCategories = categories.OrderBy(n => n);//sorted category
                foreach (var item in sortedCategories)
                {
                    Console.WriteLine("\t \t " +item);
                }
                Console.WriteLine( " ");

            }
            //calls the printCategories method when user press 1 else search for match.
            public void pressed1()
            {
                 string user_input=Console.ReadLine();
                if(user_input=="1"){
                    Console.WriteLine(" ");
                    Console.WriteLine("\t\t \t \t \t \t Available Book Categories ({0})",categories.Length);
                    Console.WriteLine("\t \t \t \t \t ___________________________________________");

                    Console.WriteLine(" ");
                    printCategories();
                    tryAgain();
                }else{
                    string input = user_input.ToLower().Trim();
                    switch (input)
                    {
                        case "french":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 1", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "mechanical engineering":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 2", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "architecture":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 3", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "transportation":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 4", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "engineering":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 5", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "computing":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 6", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "statistics":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 7", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "zoology":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 8", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "biology":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 9", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "physics":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 10", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "christian theology":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 11", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "religion":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 11", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "languages":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 12", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "physiology":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 13", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "nutrition":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 14", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "medicine":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 15", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "programing":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 16", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "software enginering":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 17", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "socialogy":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 18", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "criminology":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 19", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "english" :
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 20", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "mathematics":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 21", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "computer science":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 22", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;

                        case "science":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 25", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "arts":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 23", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "music":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 24", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "history":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 29", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "fashion":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 26", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "photography":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 27", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "social studies":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 28", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "electronic":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 30", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "magazine":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 31", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "electronics":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 32", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        case "maths":
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t {0} is located on shelf : 21", input);
                            Console.WriteLine(" ");
                            Console.WriteLine("\t \t  \t\t \t Thanks for using this app!!!");
                            Console.WriteLine("\t \t _________________________________________________________________________");
                            Console.WriteLine("");
                            tryAgain();
                            break;
                        default :
                            Console.WriteLine(" ");
                            Console.WriteLine( "\t \t\t \"{0}\" could not be FOUND in our shelf",user_input);
                            tryAgain();
                            break;
                    }
                    
                    
                }
            }
            // A method to start the book search over again
            public void tryAgain(){
            
                Console.WriteLine("Do you want to search for another category-YES OR NO ? OR  SIMPLEY PRESS \"1\" TO DISPLAY AVAILABLE CATEGORIES");
                string userDecison = Console.ReadLine();

                switch (userDecison.ToLower().Trim())
                {
                    case "yes":
                        repeat();
                        break;
                    case "no":
                        Console.WriteLine(" ");
                        Console.WriteLine("\t \t\t \t___________________________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine("\t \t\t \t  Thanks for using shelf!! we already miss you,come back sooon!");
                        Console.WriteLine(" ");
                        Console.WriteLine("\t \t\t \t---------->>>>>> PRESS ENTER TO CLOSE APP <<<<<<<------------");
                        Console.WriteLine("\t \t\t \t___________________________________________________________________");

                        break;
                    case "1":
                        Console.WriteLine(" ");
                        Console.WriteLine("\t\t \t \t \t \t Available Book Categories ({0})",categories.Length);
                        Console.WriteLine("\t \t \t \t \t ___________________________________________");
                        Console.WriteLine(" ");
                        printCategories();
                        tryAgain();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("\t\t {0} is not a valid option kindly type Yes or No or 1 .:( ", userDecison);
                        Console.WriteLine("");
                        Console.WriteLine(" ");
                        tryAgain();

                            break;
                }
            }
            //a method to start the application over again when user inputs 'yes'.
            public void repeat()
            {
                Console.WriteLine("\t \t \t **************************************************************\t \t \t");
                Console.WriteLine("\t \t \t \t \t \t Welcome to SHELF\t \t \t \t \t \t");
                Console.WriteLine("\t \t \t **************************************************************\t \t \t");
                Console.WriteLine(" \t \"SHELF\" is a program written by Elinam Quist to help students to easily  locate a book on the libray shelf.");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Enter Book Category or press \'1' to display available categories : ");
                pressed1();

            }
        }
       
        static void Main(string[] args)
        {
            Program program = new Program();
            MainApp mainApp = new MainApp();

            program.app_intro();
            mainApp.pressed1();
            Console.ReadKey();
        }
    }
}
