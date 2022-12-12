namespace BlazorApp2.Store.Counter
{
    public record IncreaseCounter
    {
        public int Step { get; set; } = 1;
    }
}
