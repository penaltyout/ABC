using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VinylCollection
{
    class Program
    {
        static void MainMenu()
        {
            Console.WriteLine("### Choose one of these options(1-4) ###");
            Console.WriteLine();
            Console.WriteLine("1. View the entire collection list");
            Console.WriteLine();
            Console.WriteLine("2. Add new information to the list");
            Console.WriteLine();
            Console.WriteLine("3. Edit album information of the list");
            Console.WriteLine();
            Console.WriteLine("4. Delete an album in the list");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1": DisplayList(); break;
                case "2": AddAlbum(); break;
                case "3": EditAlbum(); break;
                case "4": DeleteAlbum(); break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("### Choose one of these options(1-4) ###");
                        Console.WriteLine();
                        Console.WriteLine("Warning!");
                        Console.WriteLine();
                        Console.WriteLine("Choose one between 1 and 4, or you will lose your list!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key...");
                        break;
                    }
            }
            Console.ReadKey();
        }

        static void DisplayList()
        {
            Console.Clear();
            Console.WriteLine("### Here comes the entire list of your collection ###");
            Console.WriteLine();
            Console.WriteLine(File.ReadAllText("Text.txt"));
        }

        static void AddAlbum()
        {
            Console.Clear();
            Console.WriteLine("### Please add new album information ###");
            Console.WriteLine();
            Console.Write("a. Enter title of album: ");
            InputData.AlbumName = Convert.ToString(Console.ReadLine());
            Console.Write("b. Enter name of artist: ");
            InputData.ArtistName = Convert.ToString(Console.ReadLine());
            Console.Write("c. Enter genre of music: ");
            InputData.GenreName = Convert.ToString(Console.ReadLine());
            Console.Write("d. Enter year of release: ");
            InputData.ReleaseYear = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            string[] allSavedData = new string[] { InputData.AlbumName + ", " +  InputData.ArtistName + ", " + InputData.GenreName + ", " + InputData.ReleaseYear };

            Console.Write("This is what you have written: ");

            for (int i = 0; i < allSavedData.Length; i++)
            {
                if (i < allSavedData.Length - 1)
                {
                    Console.Write(allSavedData[i] + ", ");
                }
                else
                {
                    Console.Write(allSavedData[i]);
                }
            }
            File.WriteAllLines("Text.txt", allSavedData);
        }

        static void EditAlbum()
        {
            Console.Clear();
        }

        static void DeleteAlbum()
        {
            Console.Clear();
        }

        static void Main(string[] args)
        {
            do
            {
                MainMenu();
                Console.Clear();
            } while (true);

            Console.ReadKey();
        }
    }
}
