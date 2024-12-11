namespace Logging_Framework.Model
{
    public class LoggingManager: IOutputDestination
    {
        private static LoggingManager instance;
        private static readonly object lockObject = new object();
        private IOutputDestination outputDestination;
        private LogLevel logLevel;

        private LoggingManager(IOutputDestination destination, LogLevel logLevel)
        {
            this.outputDestination = destination;
            this.logLevel = logLevel;
        }
        public LoggingManager getInstance(IOutputDestination destination, LogLevel logLevel) 
        {
            if(instance == null)
            {
                lock(lockObject)
                {
                    if (instance == null)
                    {
                        instance = new LoggingManager(destination,logLevel);
                    }
                }
            }
            return instance;
        }

        public void Info(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.outputDestination.Info(message);
        }
        public void Debug(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.outputDestination.Debug(message);
        }
        public void Warn(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.outputDestination.Warn(message);
        }
        public void Error(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.outputDestination.Error(message);
        }
        public void Fatal(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.outputDestination.Fatal(message);
        }
    }

    public enum LogLevel
    {
        Info,
        Debug,
        Warn,
        Error,
        Fatal
    }
}
