using Core.Interfaces;
using Core.Models;


namespace Table.Useful.Models
{
    public class LocalStorageSettings : LocalStorageSettingsBase
    {
        public LocalStorageSettings(ILocalStorage storage)
            : base(storage)
        {
            // base level contains default settings.
        }

        public bool LoadSourcePage { get; set; }

    }
}
