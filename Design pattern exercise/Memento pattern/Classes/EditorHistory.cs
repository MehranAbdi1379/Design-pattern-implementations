using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_exercise.Classes
{
    public class EditorHistory
    {
        public EditorHistory()
        {
            editorStates = new Stack<EditorState>();
        }
        public Stack<EditorState> editorStates { get; private set; }

        public void Push(EditorState editorState)
        {
            editorStates.Push(editorState);
        }

        public void Pop()
        {
            editorStates.Pop();
        }

        public EditorState Peek()
        {
            return editorStates.Peek();
        }
    }
}
