using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        // Constructor to initialize the scripture with reference and text
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
            _random = new Random();
        }

        // Method to display the scripture
        public void Display()
        {
            Console.WriteLine(_reference.ToString()); // Display reference
            foreach (Word word in _words)
            {
                Console.Write(word.ToString() + " "); // Display each word
            }
        }

        // Method to hide a few random words
        public void HideWords()
        {
            int wordsToHide = 3;
            List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

            for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
            {
                int randomIndex = _random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
                visibleWords.RemoveAt(randomIndex);
            }
        }

        // Method to check if all words are hidden
        public bool AllWordsHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}
