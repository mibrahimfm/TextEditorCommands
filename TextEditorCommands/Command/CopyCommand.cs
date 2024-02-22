namespace TextEditorCommands.Command
{
    internal class CopyCommand : ICommand
    {
        private TextEditor _editor;
        private string _copiedText;
        private int _startIndex;
        private int _endIndex;

        public CopyCommand(TextEditor editor, int startIndex, int endIndex)
        {
            _editor = editor;
            _startIndex = startIndex;
            _endIndex = endIndex;
        }

        public void Execute()
        {
            int length = _endIndex - _startIndex + 1;
            _copiedText = _editor.GetText(_startIndex, length);
        }

        public void Undo()
        {
            _copiedText = null;
            Console.WriteLine("Uncopied text");
        }
    }
}
