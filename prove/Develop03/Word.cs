namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor to initialize the word with text
        public Word(string text)
        {
            _text = text;
            _isHidden = false; // Words are initially visible
        }

        // Method to hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Method to check if the word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Override ToString to return the word or underscores if hidden
        public override string ToString()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
}
