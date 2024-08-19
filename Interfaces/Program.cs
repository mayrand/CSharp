using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            RichTextBox r = new RichTextBox();
            r.Undo();               // RichTextBox.Undo Case 1
            ((IUndoable)r).Undo();  // RichTextBox.Undo Case 2
            ((TextBox)r).Undo();    // TextBox.Undo Case 2
        }
    }
    public interface IUndoable { void Undo(); }
    public class TextBox : IUndoable
    {
        //void IUndoable.Undo() => Console.WriteLine("TextBox.Undo");
        public virtual void Undo() => Console.WriteLine("TextBox.Undo");
    }
    public class RichTextBox : TextBox, IUndoable
    {
        public override void Undo() => Console.WriteLine("RichTextBox.Undo");
    }
}
