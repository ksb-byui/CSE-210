namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verses;

        // Constructor to initialize the reference with book, chapter, and verses
        public Reference(string book, string chapter, string verses)
        {
            _book = book;
            _chapter = chapter;
            _verses = verses;
        }

        // Override ToString to return the reference as a string
        public override string ToString()
        {
            return $"{_book} {_chapter}:{_verses}";
        }
    }
}
