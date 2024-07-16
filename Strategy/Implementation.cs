namespace Strategy
{
	/// <summary>
	/// strategy 
	/// </summary>
	public interface IExportService
	{
		void Export(Order order);
	}

	/// <summary>
	/// concrete strategy
	/// </summary>
	public class JsonExportService : IExportService
	{
		public void Export(Order order)
		{
            Console.WriteLine($"Exporting {order.Name} to Json");
        }
	}

	/// <summary>
	/// concrete strategy
	/// </summary>
	public class XMLExportService : IExportService
	{
		public void Export(Order order)
		{
			Console.WriteLine($"Exporting {order.Name} to XML");
		}
	}

	/// <summary>
	/// concrete strategy
	/// </summary>
	public class CSVExportService : IExportService
	{
		public void Export(Order order)
		{
			Console.WriteLine($"Exporting {order.Name} to CSV");
		}
	}

	/// <summary>
	/// context
	/// </summary>
	public class Order
	{
		
		public string Customer { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }

        public Order(string customer, string name, int amount)
		{ 
			Customer = customer;
			Name = name;
			Amount = amount;
		}

		public void Export(IExportService exportService)
		{
			if (exportService == null) {
				throw new ArgumentNullException(nameof(exportService));
			}
			exportService?.Export(this);
		}
	}
}
