namespace MangaChecker
{
    partial class FormAddingManga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbTitle = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            TbDesc = new RichTextBox();
            tbUrl = new TextBox();
            label3 = new Label();
            tbSnippet = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            lConf = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 15);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(50, 50);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(212, 23);
            tbTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Location = new Point(208, 289);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Manga";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // TbDesc
            // 
            TbDesc.Location = new Point(56, 127);
            TbDesc.Name = "TbDesc";
            TbDesc.Size = new Size(206, 125);
            TbDesc.TabIndex = 5;
            TbDesc.Text = "";
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(379, 46);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(206, 23);
            tbUrl.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 32);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // tbSnippet
            // 
            tbSnippet.Location = new Point(379, 127);
            tbSnippet.Name = "tbSnippet";
            tbSnippet.Size = new Size(206, 125);
            tbSnippet.TabIndex = 8;
            tbSnippet.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 15);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "URL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 98);
            label5.Name = "label5";
            label5.Size = new Size(153, 15);
            label5.TabIndex = 10;
            label5.Text = "Part indicating next chapter";
            // 
            // lConf
            // 
            lConf.AutoSize = true;
            lConf.ForeColor = Color.FromArgb(0, 192, 0);
            lConf.Location = new Point(269, 260);
            lConf.Name = "lConf";
            lConf.Size = new Size(0, 15);
            lConf.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Location = new Point(333, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 45);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormAddingManga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 358);
            Controls.Add(btnClear);
            Controls.Add(lConf);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbSnippet);
            Controls.Add(tbUrl);
            Controls.Add(label3);
            Controls.Add(TbDesc);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddingManga";
            Text = "FormAddingManga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTitle;
        private TextBox textBox2;
        private Label label2;
        private Button btnAdd;
        private RichTextBox TbDesc;
        private TextBox tbUrl;
        private Label label3;
        private RichTextBox tbSnippet;
        private Label label4;
        private Label label5;
        private Label lConf;
        private Button btnClear;
    }
}