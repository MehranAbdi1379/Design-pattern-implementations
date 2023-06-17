using Chain_of_responsibility_pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var chainStarter = new Authenticator();
        chainStarter.AddToEndOfTheChain(new Logger());
        chainStarter.AddToEndOfTheChain(new Compressor());


        var httpRequest = new HttpRequest("admin", "1234");

        var webServer = new WebServer(chainStarter);

        webServer.Handle(httpRequest);  
    }
}