

namespace ObjectAdapter
{
   public class CityFromExternalSystem
   {
        public CityFromExternalSystem(string name, string nickName, int inhibtants)
        {
            Name = name;
            NickName = nickName;
            Inhibtants = inhibtants;
        }

        public string Name { get;private set; }
        public string NickName { get;private set; }
        public int Inhibtants { get;private set; }

    }
    /// <summary>
    /// Adaptee
    /// </summary>
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("mahalla", "maha", 5000000);
        }
    }

    public class city
    {
        public city(string fullName, long inhibtants)
        {
            FullName = fullName;
            Inhibtants = inhibtants;
        }

        public string FullName { get;private set; }
        public long Inhibtants { get;private set; }
    }

    /// <summary>
    /// Target
    /// </summary>
    public interface ICityAdapter
    {
        city GetCity();
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class cityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystem { get;private set; } = new();
        public city GetCity()
        {
            // call into external system
            var cityFromExternalSystem = ExternalSystem.GetCity();
			// adapt from cityFromExternalSystem to city
			return new city($"{cityFromExternalSystem.Name} , {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhibtants);
        }
    }


}



