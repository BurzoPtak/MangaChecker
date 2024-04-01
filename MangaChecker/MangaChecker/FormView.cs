using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace MangaChecker
{
  
    public partial class FormView : FormAddingManga
    {
        public FormView()
        {
            InitializeComponent();
            ReadJson();

        }


        private void ReadJson()
        {
            string path = "Launcher/Mangas/Saves.json";
            FlowPanelItems.Controls.Clear();
            if (File.Exists(path))
            {
                string JsonFile = File.ReadAllText(path);
                List <JsonTemplate> MangaData = JsonConvert.DeserializeObject<List<JsonTemplate>>(JsonFile);
                List<MangaItem> Items = new List<MangaItem>();   
                for (int i = 0; i < MangaData.Count; i++)
                {
                    Items.Add(new MangaItem() { Title = MangaData[i].title,Url = MangaData[i].url,Description = MangaData[i].description,Snippet = MangaData[i].snippet });
                    FlowPanelItems.Controls.Add(Items[i]);
                }
            }
        }
        public List<MangaItem>  GetData()
        {
            List<MangaItem> items = new List<MangaItem>();

            foreach (Control control in FlowPanelItems.Controls)
            {
                if (control is MangaItem itemControl)
                {
                    items.Add(itemControl);
                }
            }

            return items;
        }

    }
}
