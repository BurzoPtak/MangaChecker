using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Newtonsoft.Json;
namespace MangaChecker
{
    //Template
    public class JsonTemplate
    {
        public string title { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string snippet { get; set; }
        public JsonTemplate(string title, string url, string description, string snippet)
        {
            this.title = title;
            this.url = url;
            this.description = description;
            this.snippet = snippet;
        }
    }
    public partial class FormAddingManga : Form
    {
        
        public FormAddingManga()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = "Launcher/Mangas/Saves.json";
            //Uri - uniform resource identifier / checking if url provided by user is valid then converting to Json using Newtonsoft lib
            Uri uriResult;
            if (Uri.TryCreate(tbUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                JsonTemplate data = new JsonTemplate(tbTitle.Text, tbUrl.Text, TbDesc.Text, tbSnippet.Text);
                string serialized = JsonConvert.SerializeObject(data, Formatting.Indented);
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "[");
                }
                List<string> list = new List<string>(File.ReadAllLines(path));
                list[list.Count - 1] = list[list.Count - 1].Replace(']', ',');
                File.WriteAllLines(path, list);
                File.AppendAllText(path, serialized + "\n]");
                lConf.ForeColor = Color.Green;
                lConf.Text = "Manga named " + tbTitle.Text + " Added :-)";
                tbTitle.Text = "";
                tbUrl.Text = "";
                TbDesc.Text = "";
            }
            else
            {
                lConf.ForeColor = Color.Red;
                lConf.Text = "Manga not added, check Url ";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            TbDesc.Text = "";
            tbUrl.Text = "";
            tbSnippet.Text = "";
        }
    }
}
