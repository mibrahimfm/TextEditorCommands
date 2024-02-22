namespace TextEditorCommands.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
