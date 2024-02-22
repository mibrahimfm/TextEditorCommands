using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorCommands.Command
{
    internal class CutCommand : ICommand
    {
        private TextEditor _editor;
        private string _cutText;
        private int _startIndex;
        private int _length;

        public CutCommand(TextEditor textEditor, int startIndex, int length)
        {
            _editor = textEditor;
            _startIndex = startIndex;
            _length = length;
        }

        public void Execute()
        {
            _cutText = _editor.GetText(_startIndex, _length);
            _editor.CutText(_startIndex, _length);
        }

        public void Undo()
        {
            _editor.PasteText(_startIndex, _cutText);
        }
    }
}
