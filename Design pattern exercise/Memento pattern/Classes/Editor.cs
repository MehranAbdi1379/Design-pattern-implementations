using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_exercise.Classes
{
    public class Editor
    {
        public Editor()
        {
            History = new EditorHistory();
            NewState("", "");
        }
        public EditorHistory History { get; private set; }

        public void NewState(string title , string description)
        {
            var state = new EditorState();
            state.Title = title;
            state.Description = description;

            History.Push(state);
        }

        public EditorState Undo()
        {
            if(History.editorStates.Count>1)
            {
                History.Pop();
            }
            
            return History.Peek();
        }
    }
}
