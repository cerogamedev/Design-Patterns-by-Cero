using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Stack<ICommand> undoStack = new Stack<ICommand>();
    private Stack<ICommand> redoStack = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
        redoStack.Clear();
    }
    public void UndoCommand()
    {
        if (undoStack.Count>0)
        {
            ICommand activeCommand = undoStack.Pop();
            redoStack.Push(activeCommand);
            activeCommand.Undo();
        }
        else
        {
            Debug.Log("Nothing undo!!!");
        }
    }
    public void RedoCommand()
    {
        if (redoStack.Count > 0)
        {
            ICommand activeCommand = redoStack.Pop();
            undoStack.Push(activeCommand);
            activeCommand.Execute();
        }
        else
        {
            Debug.Log("Nothing to redo!!!");
        }
    }
}
