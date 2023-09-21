namespace Ux.Common.Interfaces
{
    public interface IButton
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}
