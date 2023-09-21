using Core.Interfaces;
using System;

namespace Core.Models
{
    public abstract class LocalStorageSettingsBase : ILocalStorageSettingsBase
    {

        private ILocalStorage localStorage { get; set; }

        private const string showInstrKey = "showInstructions";
        private const string pinMenu = "pinMenu";

        public LocalStorageSettingsBase(ILocalStorage storage)
        {
            localStorage = storage;
        }

        public bool ShowInstructions
        {
            get
            {
                return Get(showInstrKey, "true");
            }
            set
            {
                localStorage.SetItem(showInstrKey, value.ToString());
                NotifyStateChanged();
            }
        }

        public bool PinMenu
        {
            get
            {
                return Get(pinMenu, "false");
            }
            set
            {
                localStorage.SetItem(pinMenu, value.ToString());
                NotifyStateChanged();
            }
        }

        private bool Get(string key, string defaultSetting)
        {
            try
            {
                return bool.Parse(localStorage.GetItem(key));
            }
            catch
            {
                localStorage.SetItem(key, defaultSetting);
                return true;
            }
        }

        public void ClearLocalStorage()
        {
            localStorage.Clear();
            return;
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
