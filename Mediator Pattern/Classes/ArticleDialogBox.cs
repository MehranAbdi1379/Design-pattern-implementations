using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public class ArticleDialogBox 
    {
        protected readonly ArticleListBox articleListBox;
        protected readonly SaveButton saveButton;
        protected readonly TitleTextBox titleTextBox;

        public ArticleDialogBox()
        {
            articleListBox = new ArticleListBox();
            titleTextBox = new TitleTextBox();
            saveButton = new SaveButton();
            articleListBox.attach(new SelectedObserver(saveButton, articleListBox, titleTextBox));
            titleTextBox.attach(new TitleChangeObserver(saveButton, articleListBox, titleTextBox));
        }

        public void SimulateUserInteraction()
        {
            articleListBox.Selection="Kebab.";
            Console.WriteLine(articleListBox.Selection);
            Console.WriteLine(titleTextBox.Content);
            Console.WriteLine(saveButton.IsActivated);
            titleTextBox.Content = "";
            Console.WriteLine(articleListBox.Selection);
            Console.WriteLine(titleTextBox.Content);
            Console.WriteLine(saveButton.IsActivated);
            titleTextBox.Content = "Kofte";
            Console.WriteLine(articleListBox.Selection);
            Console.WriteLine(titleTextBox.Content);
            Console.WriteLine(saveButton.IsActivated);
        }
    }
}
