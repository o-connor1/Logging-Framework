namespace Logging_Framework.Model
{
    public class Database: LoggerStrategy
    {

        public Database(LogLevel level, string connectionString) : base(level, connectionString)
        {
        }

        public override void write(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            //implementation
        }
    }
}
