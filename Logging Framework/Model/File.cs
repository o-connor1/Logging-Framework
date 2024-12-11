namespace Logging_Framework.Model
{
    public class File: LoggerStrategy
    {
        private readonly string _name;

        public File(LogLevel level, string connectionString) : base(level, connectionString)
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
