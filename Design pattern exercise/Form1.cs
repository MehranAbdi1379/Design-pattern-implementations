using Design_pattern_exercise.Classes;

namespace Design_pattern_exercise
{
    public partial class Form1 : Form
    {
        public Editor Editor { get; set; } = new Editor();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Editor.History.editorStates.Count == 1)
            {
                var lastState = Editor.Undo();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (Editor.History.editorStates.Count > 1)
            {
                var lastState = Editor.Undo();
                textBox1.Text = lastState.Title;
                textBox2.Text = lastState.Description;
            }
                
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Editor.NewState(textBox1.Text,textBox2.Text);
        }
    }
}