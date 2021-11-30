namespace LogManager.Domain
{
    public class DataLog<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
