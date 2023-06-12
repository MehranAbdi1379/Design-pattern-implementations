using Observer_Pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var chart = new Chart();
        var spreadSheet = new SpreadSheet();

        var dataSource = new DataSource(0);

        dataSource.AddObserver(chart);
        dataSource.AddObserver(spreadSheet);

        dataSource.Index = 5;
        dataSource.Index = 6;
        dataSource.Index = 50;
    }
}