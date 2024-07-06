namespace Singleton
{
  
   /// <summary>
   /// Singleton
   /// </summary>
   
    public class Logger
    {
        //lazy initialization

        private static readonly Lazy<Logger> _loggerInstace = new Lazy<Logger>(() => new Logger());

       // private static Logger? _instance;

        protected Logger()
        {

        }
        /// <summary>
        /// signleton instance
        /// </summary>
        public static Logger Instacne
        {
            get
            {
                return _loggerInstace.Value;
                //if(_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }

        /// <summary>
        /// singleton method
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"message to log {message}");
        }

    }

}
