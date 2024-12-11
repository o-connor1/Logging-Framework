namespace Logging_Framework.Model
{
    public class LoggingManager
    {
        private static LoggingManager instance;
        private static readonly object lockObject = new object();
        private LoggerStrategy loggerStrategy;

        private LoggingManager(LoggerStrategy loggerStrategy)
        {
            this.loggerStrategy = loggerStrategy;
        }
        public static LoggingManager getInstance(LoggerStrategy loggerStrategy) 
        {
            if(instance == null)
            {
                lock(lockObject)
                {
                    if (instance == null)
                    {
                        instance = new LoggingManager(loggerStrategy);
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
            this.loggerStrategy.write(message);
        }
        public void Debug(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (this.loggerStrategy.getLogLevel() != LogLevel.Debug)
            {
                return;
            }
            this.loggerStrategy.write(message);
        }
        public void Warn(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.loggerStrategy.write(message);
        }
        public void Error(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.loggerStrategy.write(message);
        }
        public void Fatal(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            this.loggerStrategy.write(message);
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
