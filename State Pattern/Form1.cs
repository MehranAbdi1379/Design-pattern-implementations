using State_Pattern.Classes;

namespace State_Pattern
{
    public partial class Form1 : Form
    {
        public Canvas Canvas{ get; set; } = new Canvas();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canvas.Tool = new SelectionTool();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Canvas.Tool = new DrawTool();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Canvas.Tool = new DeleteTool();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Canvas.MouseDown();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Canvas.MouseUp();
        }
    }
}