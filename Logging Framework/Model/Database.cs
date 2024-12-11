namespace Logging_Framework.Model
{
    public class Database: IOutputDestination
    {
        private readonly string connectionString;

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Info(string message)
        {
            //implementation
        }

        public void Debug(string message)
        {
            //implementation
        }

        public void Warn(string message)
        {
            //implementation
        }

        public void Error(string message)
        {
            //implementation
        }

        public void Fatal(string message)
        {
            //implementation
        }
    }
}
