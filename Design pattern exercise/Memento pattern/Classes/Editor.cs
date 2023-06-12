using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_exercise.Memento_pattern.Classes
{
    public class Editor
    {
        public Editor()
        {
            History = new EditorHistory();
        }

        public EditorHistory History{ get; set; }

        public void Push(string title , string description)
        {
            History.Push(title, description);
        }

        public EditorState Pop()
        {
            return History.Pop();
        }
    }
}
