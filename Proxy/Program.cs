using Proxy;

Console.Title = "Proxy";

// without proxy
Console.WriteLine("construting document");
var document = new Document("document.txt");
Console.WriteLine("document constructed");
document.DisplayDocument();

Console.WriteLine();

// with proxy
Console.WriteLine("construting document proxy");
var documentProxy = new DocumentProxy("document.txt");
Console.WriteLine("document proxy constructed");
documentProxy.DisplayDocument();

Console.WriteLine();

// with protected proxy
Console.WriteLine("constructing protected document proxy");
var protectedDocumentProxy = new ProtectedDocumentProxy("document.txt", "Admin");
Console.WriteLine("protected document proxy constructed");
protectedDocumentProxy.DisplayDocument();

Console.WriteLine();

// without protected proxy
Console.WriteLine("constructing protected document proxy");
var withoutProtectedDocumentProxy = new ProtectedDocumentProxy("document.txt", "Viewer");
Console.WriteLine("protected document proxy constructed");
withoutProtectedDocumentProxy.DisplayDocument();