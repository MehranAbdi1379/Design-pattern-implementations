using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Classes
{
    public class SelectedObserver : IObserver
    {
        private readonly SaveButton saveButton;
        private readonly ArticleListBox articleListBox;
        private readonly TitleTextBox titleTextBox;

        public SelectedObserver(SaveButton saveButton, ArticleListBox articleListBox, TitleTextBox titleTextBox)
        {
            this.saveButton = saveButton;
            this.articleListBox = articleListBox;
            this.titleTextBox = titleTextBox;
        }

        public void update()
        {
            titleTextBox.Content = articleListBox.Selection;
            saveButton.IsActivated = true;
        }
    }
}
