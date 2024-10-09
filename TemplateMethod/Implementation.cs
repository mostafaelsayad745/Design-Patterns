namespace TemplateMethod
{
	/// <summary>
	/// Abstract class
	/// </summary>
	public abstract class MailParser
	{
		public virtual void FindServer()
		{
			Console.WriteLine("Finding server...");
		}

		public abstract void AuthenticateToServer();

		public string ParseHtmlMailBody(string identifier)
		{
			Console.WriteLine("parsing html mail body ....");
			return $"Parsed mail body with identifier {identifier}";
		}

		/// <summary>
		/// template method
		/// </summary>
		/// <param name="identifier"></param>
		public string ParseMailBody(string identifier)
		{
			Console.WriteLine("parsing mail body (in template method)....");
			FindServer();
			AuthenticateToServer();
			return ParseHtmlMailBody(identifier);
		}
	}

	public class ExchangeMaiIParser : MailParser
	{
		public override void AuthenticateToServer()
		{
			Console.WriteLine("Authenticating to Exchange server...");
		}
	}

	public class GmailMailParser : MailParser
	{
		public override void AuthenticateToServer()
		{
			Console.WriteLine("Authenticating to Gmail server...");
		}
	}

	public class EudoraMailParser : MailParser
	{
		public override void FindServer()
		{
            Console.WriteLine("Finding Eudora server through a custom algorithm...");
		}
		public override void AuthenticateToServer()
		{
			Console.WriteLine("Authenticating to Eudora server...");
		}
	}
}
