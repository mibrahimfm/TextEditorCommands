using TextEditorCommands;
using TextEditorCommands.Command;
using TextEditorCommands.Invoker;

TextEditor editor = new();
CommandInvoker invoker = new();

editor.SetText("Hello, world!");

ICommand copyCommand = new CopyCommand(editor, 0, 12);
ICommand cutCommand = new CutCommand(editor, 5, 7);
ICommand pasteCommand = new PasteCommand(editor, "AM", 5);

invoker.ExecuteCommand(copyCommand);
invoker.ExecuteCommand(cutCommand);
invoker.ExecuteCommand(pasteCommand);

invoker.UndoLastCommand();
invoker.UndoLastCommand();

Console.WriteLine();
editor.Display();