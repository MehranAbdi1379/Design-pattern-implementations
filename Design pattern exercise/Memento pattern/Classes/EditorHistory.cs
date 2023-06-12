using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_exercise.Memento_pattern.Classes
{
    public class EditorHistory
    {
        public Stack<EditorState> EditorStates { get; set; }

        public void Push(string title , string description)
        {
            var editorState = new EditorState();
            editorState.Title = title;
            editorState.Description = description;

            EditorStates.Push(editorState);
        }

        public EditorState Pop()
        {
            return EditorStates.Pop();
        }
    }
}
