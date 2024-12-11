namespace Logging_Framework.Model
{
    public abstract class LoggerStrategy
    {
        protected LogLevel _level;
        protected string path;

        public LoggerStrategy(LogLevel logLevel, string path)
        {
            this._level = logLevel;
            this.path = path;
        }

        public LogLevel getLogLevel()
        {
            return _level;
        }
        public virtual void write(string message)
        {

        }
    }
}
