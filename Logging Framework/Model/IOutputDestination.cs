namespace Logging_Framework.Model
{
    public interface IOutputDestination
    {
        void Info(string message);

        void Debug(string message);

        void Warn(string message);

        void Error(string message);

        void Fatal(string message);
    }
}
