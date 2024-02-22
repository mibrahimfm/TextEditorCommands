namespace TextEditorCommands.Command
{
    internal class PasteCommand : ICommand
    {
        private TextEditor _editor;
        private string _copiedText;
        private int _startIndex;

        public PasteCommand(TextEditor textEditor, string copiedText, int startIndex)
        {
            _editor = textEditor;
            _copiedText = copiedText;
            _startIndex = startIndex;
        }

        public void Execute()
        {
            _editor.PasteText(_startIndex, _copiedText);
        }

        public void Undo()
        {
            _editor.CutText(_startIndex, _copiedText.Length);
        }
    }
}
