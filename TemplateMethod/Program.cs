using TemplateMethod;

Console.Title = "Template Method";

var exchangeMaiIParser = new ExchangeMaiIParser();
exchangeMaiIParser.ParseMailBody("123");
Console.WriteLine();


var gmailMailParser = new GmailMailParser();
gmailMailParser.ParseMailBody("456");
Console.WriteLine();


var eudoraMailParser = new EudoraMailParser();
eudoraMailParser.ParseMailBody("789");
Console.WriteLine();
