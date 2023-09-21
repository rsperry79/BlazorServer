using Core.Interfaces;
using Core.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Table.Useful.Models;

namespace Table.Useful.Models
{
    public class TableViewModel : ViewModel
    {
        private HitData hitData = new();
        private JudgementData judgementData;

        public HitData HitData
        {
            get => hitData; set
            {
                hitData = value;
                NotifyStateChanged();
            }
        }

        public JudgementData JudgementData
        {
            get => judgementData; set
            {
                judgementData = value;
                NotifyStateChanged();
            }
        }

        public TableViewModel( JudgementData judgementData)
            : base()
        {
            // base level covers most cases.
            this.judgementData = judgementData;

            xServer = new xServer.xServer();
        }


        public override async Task GetDataAsync()

        {
            await base.GetDataAsync();

            try
            {
                HitData = JsonConvert.DeserializeObject<HitData>(data.HitData.ToString());
                NotifyStateChanged();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
