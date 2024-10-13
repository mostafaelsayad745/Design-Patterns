namespace Proxy
{
	/// <summary>
	///  subject
	/// </summary>
	public interface IDocument
	{
		void DisplayDocument();
	}

	/// <summary>
	/// Real subject
	/// </summary>
	public class Document : IDocument
	{
        public string? Title { get;private set; }
        public string? Content { get;private set; }
        public int AuthorId { get;private set; }
        public DateTimeOffset LastAccessed { get; set; }

        private string _fileName;

		public Document(string fileName)
		{
			_fileName = fileName;
			LoadDocument(fileName);
		}

		private void LoadDocument(string fileName)
		{
            Console.WriteLine("Executing expensive atcion : loading file from the disk");

			//  fake loading document from disk
			Thread.Sleep(1000);

			Title = "An expensive document";
			Content = "This is a very expensive document";
			AuthorId = 1;
			LastAccessed = DateTimeOffset.Now;
		}

		public void DisplayDocument()
		{
			Console.WriteLine($"Title: {Title} , content : {Content}");
		}
	}


	/// <summary>
	/// Proxy class
	/// </summary>
	public class DocumentProxy : IDocument
	{
		// avoid creating the document until it is actually needed
		private Lazy<Document> _document;
		private string _fileName;

		public DocumentProxy(string fileName)
		{
			_fileName = fileName;
			_document = new Lazy<Document>(() => new Document(fileName));
		}

		public void DisplayDocument()
		{
			_document.Value.DisplayDocument();
		}
	}
	/// <summary>
	/// protected proxy : chain of proxy
	/// </summary>
	public class ProtectedDocumentProxy : IDocument
	{
		private string _fileName;
		private string _userRole;
		private DocumentProxy _documentProxy;

		public ProtectedDocumentProxy(string fileName, string userRole)
		{
			_fileName = fileName;
			_userRole = userRole;
			_documentProxy = new DocumentProxy(_fileName);
		}

		public void DisplayDocument()
		{
            Console.WriteLine($"Entering Display Document in {nameof(ProtectedDocumentProxy)}");
			if (_userRole != "Admin")
				throw new UnauthorizedAccessException("Admins are not allowed to view this document");
			_documentProxy.DisplayDocument();
			Console.WriteLine($"Exiting Display Document in {nameof(ProtectedDocumentProxy)}");
		}
	}
}
