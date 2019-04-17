namespace Hanoi
{
    public sealed class DiscMove
    {
        public short Id { get; set; }
        public PegLocation Origin { get; set; }
        public PegLocation Destination { get; set; }
    }
}
