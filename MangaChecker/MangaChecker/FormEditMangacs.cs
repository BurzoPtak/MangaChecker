using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MangaChecker
{
    public partial class FormEditMangacs : Form
    {
        JsonTemplate data;
        int index;
        List<JsonTemplate> MangaData;
        string path = "Launcher/Mangas/Saves.json";
        public FormEditMangacs(JsonTemplate dataFromForm)
        {
            index = 0;
            InitializeComponent();
            tbTitle.Text = dataFromForm.title;
            tbUrl.Text = dataFromForm.url;
            TbDesc.Text = dataFromForm.description;
            tbSnippet.Text = dataFromForm.snippet;
            string JsonFile = File.ReadAllText(path);
            MangaData = JsonConvert.DeserializeObject<List<JsonTemplate>>(JsonFile);
            data = dataFromForm;
            foreach (JsonTemplate i in MangaData)
            {
                if (JsonConvert.SerializeObject(i) == JsonConvert.SerializeObject(data))
                {
                    break;
                }
                index++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            tbUrl.Text = "";
            TbDesc.Text = "";
            tbSnippet.Text = "";
        }

        public event EventHandler<EventArgs> CancelClicked;
        public void btnCancel_Click(object sender, EventArgs e)
        {

            CancelClicked?.Invoke(this, e);


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            if (Uri.TryCreate(tbUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                MangaData[index].title = tbTitle.Text;
                MangaData[index].url = tbUrl.Text;
                MangaData[index].description = TbDesc.Text;
                MangaData[index].snippet = tbSnippet.Text;
                string serialized = JsonConvert.SerializeObject(MangaData, Formatting.Indented);
                File.WriteAllText(path, serialized);
                btnCancel_Click(sender, e);

            }
            else
            {
                lConf.ForeColor = Color.Red;
                lConf.Text = "Manga not Edited, check Url ";
            }

        }
    }
}
