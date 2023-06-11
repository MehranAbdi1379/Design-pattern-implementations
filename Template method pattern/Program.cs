using Template_method_pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var auditTrail = new AuditTrail();

        TransferMoneyTask transferMoneyTask = new TransferMoneyTask(auditTrail);
        GenerateReportTask generateReportTask = new GenerateReportTask(auditTrail);


        transferMoneyTask.Execute();
        generateReportTask.Execute();
        transferMoneyTask.Execute();
        transferMoneyTask.Execute();
        generateReportTask.Execute();


    }
}