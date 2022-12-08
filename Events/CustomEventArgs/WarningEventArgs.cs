namespace BlazorApp2.Events.CustomEventArgs
{
    public class WarningEventArgs : EventArgs
    {
        public string Message { get; set; }
        public DateTime Date { get; } = DateTime.Now;
    }
}
