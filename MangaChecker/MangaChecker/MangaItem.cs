using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MangaChecker
{

    public partial class MangaItem : UserControl
    {
        public static JsonTemplate Holder;
        public MangaItem()
        {
            InitializeComponent();
        }

        private string title;
        private string url;
        private string description;
        private string snippet;
        public event EventHandler<JsonTemplate> EditClick;
        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            Holder = new JsonTemplate(Title, Url, Description, Snippet);
            //? to ensure that is not null
            EditClick?.Invoke(this, Holder);

        }

        private void lDesc_Hover(object sender, EventArgs e)
        {
            ToolTip FullDesc = new ToolTip();
            FullDesc.SetToolTip(lDesc,lDesc.Text);
        }

        private void lItemTitle_Hover(object sender, EventArgs e)
        {
            ToolTip FullDesc = new ToolTip();
            FullDesc.SetToolTip(lItemTitle, lItemTitle.Text);
        }

        [Category("Json Data")]
        public string Title
        {
            get { return title; }
            set { title = value; lItemTitle.Text = value; }
        }
        [Category("Json Data")]
        public string Url { get { return url; } set { url = value; lItemUrl.Text = value; } }
        [Category("Json Data")]
        public string Description { get { return description; } set { description = value; lDesc.Text = value; } }
        [Category("Json Data")]
        public string Snippet { get { return snippet; } set { snippet = value; } }
    }
}
