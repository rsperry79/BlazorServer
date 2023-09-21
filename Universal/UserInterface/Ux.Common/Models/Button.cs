using Ux.Common.Interfaces;

namespace Ux.Common.Models
{
    public class Button : IButton
    {
        // The HTML ID of the button used.
        public string Id { get; set; }

        // The button text
        public string DisplayName { get; set; }

        // The hover over text
        public string Description { get; set; }

        // The value sent back
        public int Value { get; set; }
    }
}
