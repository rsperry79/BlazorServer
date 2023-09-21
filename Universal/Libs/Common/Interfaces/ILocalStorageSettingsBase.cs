using System;

namespace Core.Interfaces
{
    public interface ILocalStorageSettingsBase
    {
        bool ShowInstructions { get; set; }

        bool PinMenu { get; set; }

        event Action OnChange;

        void ClearLocalStorage();
    }
}
