namespace Logging_Framework.Model
{
    public class File: IOutputDestination
    {
        private readonly string _name;

        public File(string path)
        {
            this._name = path;
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
