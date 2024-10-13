using Decorator;

Console.Title = "Decorator";

// instantiate mail services
var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hello from cloud mail service");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Hello from on-premise mail service");

//add behavior to mail services

var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wrapper");

// add more behavior to mail services

var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper , message1");

messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper , message2");

foreach (var decorator in messageDatabaseDecorator.SentMessages)
{
    Console.WriteLine($"Stored message : \"{decorator}\"");
}