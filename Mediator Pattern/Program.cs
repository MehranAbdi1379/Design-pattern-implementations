using Mediator_Pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var dialogBox = new ArticleDialogBox();
        dialogBox.SimulateUserInteraction();
    }
}