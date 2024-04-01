using System.Diagnostics;

namespace MangaChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButtonColorReset(btnSideAdd);
            lbTabTitle.Text = "Add";
            this.pnlContent.Controls.Clear();
            FormAddingManga formAddingManga = new FormAddingManga() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formAddingManga);
            formAddingManga.Show();


        }



        //Function that highlights active button
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnSideAdd.BackColor = btnColor;
            btnSideEdit.BackColor = btnColor;
            btnSideView.BackColor = btnColor;
            btnSideLaunch.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void btnSideAdd_Click(object sender, EventArgs e)
        {
            btnSideEdit.Visible = false;
            ButtonColorReset(btnSideAdd);
            lbTabTitle.Text = "Add";
            this.pnlContent.Controls.Clear();
            FormAddingManga formAddingManga = new FormAddingManga() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formAddingManga);
            formAddingManga.Show();
        }

        private void btnSideView_Click(object sender, EventArgs e)
        {
            btnSideEdit.Visible = false;
            ButtonColorReset(btnSideView);
            lbTabTitle.Text = "View";
            this.pnlContent.Controls.Clear();
            FormView formView = new FormView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formView);
            //Recieving list of items from FormView and subcribing it to event handler
            List<MangaItem> data = formView.GetData();
            foreach (MangaItem mangaItem in data)
            {
                mangaItem.EditClick += DataFromItem;
            }
            formView.Show();
        }
        private void DataFromItem(object sender, JsonTemplate? e)
        {
            btnSideEdit.Visible = true;
            ButtonColorReset(btnSideEdit);
            lbTabTitle.Text = "Edit";
            this.pnlContent.Controls.Clear();
            FormEditMangacs formEditMangacs = new FormEditMangacs(e) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEditMangacs.CancelClicked += ReturnToList;
            this.pnlContent.Controls.Add(formEditMangacs);
            formEditMangacs.Show();


        }
        private void ReturnToList(object sender, EventArgs e)
        {
          btnSideView_Click(sender, e);
        }

        private void btnSideLaunch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C py ./Launcher/main.py";
            process.StartInfo = startInfo;
            process.Start(); 


        }


    }
}
