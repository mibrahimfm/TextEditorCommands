namespace TextEditorCommands
{
    internal class TextEditor
    {
        private string _text = "";

        public string GetText(int startIndex, int length)
        {
            return _text.Substring(startIndex, length);
        }

        public void SetText(string text)
        {
            _text = text;
            Console.WriteLine("Text set: " + _text);
        }
        public void CutText(int startIndex, int length)
        {
            Console.WriteLine("Cut text: " + _text.Substring(startIndex, length));
            _text = _text.Remove(startIndex, length);
        }

        public void PasteText(int startIndex, string copiedText)
        {
            _text = _text.Insert(startIndex, copiedText);
            Console.WriteLine("Inserted " + copiedText);
        }

        public void Display()
        {
            Console.WriteLine(_text);
        }
    }
}
