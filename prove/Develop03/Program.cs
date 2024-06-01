using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // (STRETCH) Create a library of scriptures
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("1 Nephi", "3", "6-7"), "6 Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured.\n7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
                new Scripture(new Reference("John", "3", "16"), "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("1 Nephi", "2", "15"), "15 And my father dwelt in a tent."),
                new Scripture(new Reference("3 Nephi", "12", "1"), "1 And it came to pass that when Jesus had spoken these words unto Nephi, and to those who had been called, (now the number of them who had been called, and received power and authority to baptize, was twelve) and behold, he stretched forth his hand unto the multitude, and cried unto them, saying: Blessed are ye if ye shall give heed unto the words of these twelve whom I have chosen from among you to minister unto you, and to be your servants; and unto them I have given power that they may baptize you with water; and after that ye are baptized with water, behold, I will baptize you with fire and with the Holy Ghost; therefore blessed are ye if ye shall believe in me and be baptized, after that ye have seen me and know that I am.")
            };

            // Randomly select a scripture from the library
            Random random = new Random();
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear(); // Clear the console screen
                selectedScripture.Display(); // Display the scripture
                Console.WriteLine("\n\nPress Enter to hide a few words or type 'quit' to exit.");
                string input = Console.ReadLine(); // Get user input
                if (input.ToLower() == "quit")
                {
                    break; // Exit if user types quit
                }
                selectedScripture.HideWords(); // Hide random words
                if (selectedScripture.AllWordsHidden())
                {
                    Console.Clear();
                    selectedScripture.Display(); // Display scripture when all words are hidden
                    break;
                }
            }
        }
    }
}

// To show creativity and exceed requirements, I created a library with 4 scriptures that are chosen from randomly to help the user memorize multiple scriptures.