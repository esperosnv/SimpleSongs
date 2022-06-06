namespace SimpleSongs.Controllers.Utils
{
    public interface IInputSystem
    {
        string FetchStringValue(string prompt);
        double FetchDoubleValue(string prompt);
        //int FetchIntValue(string prompt);

    }
}