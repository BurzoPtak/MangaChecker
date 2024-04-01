namespace MangaChecker
{
    partial class FormEditMangacs
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
            btnClear = new Button();
            lConf = new Label();
            label5 = new Label();
            label4 = new Label();
            tbSnippet = new RichTextBox();
            tbUrl = new TextBox();
            label3 = new Label();
            TbDesc = new RichTextBox();
            btnEdit = new Button();
            label2 = new Label();
            tbTitle = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Location = new Point(288, 294);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 45);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lConf
            // 
            lConf.AutoSize = true;
            lConf.ForeColor = Color.FromArgb(0, 192, 0);
            lConf.Location = new Point(282, 265);
            lConf.Name = "lConf";
            lConf.Size = new Size(0, 15);
            lConf.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 103);
            label5.Name = "label5";
            label5.Size = new Size(153, 15);
            label5.TabIndex = 22;
            label5.Text = "Part indicating next chapter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 20);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 21;
            label4.Text = "URL";
            // 
            // tbSnippet
            // 
            tbSnippet.Location = new Point(392, 132);
            tbSnippet.Name = "tbSnippet";
            tbSnippet.Size = new Size(206, 125);
            tbSnippet.TabIndex = 20;
            tbSnippet.Text = "";
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(392, 51);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(206, 23);
            tbUrl.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 37);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 18;
            // 
            // TbDesc
            // 
            TbDesc.Location = new Point(69, 132);
            TbDesc.Name = "TbDesc";
            TbDesc.Size = new Size(206, 125);
            TbDesc.TabIndex = 17;
            TbDesc.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImageLayout = ImageLayout.None;
            btnEdit.Location = new Point(174, 294);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 45);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit Manga";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 15;
            label2.Text = "Description";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(63, 55);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(212, 23);
            tbTitle.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 13;
            label1.Text = "Title";
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.Location = new Point(402, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 45);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormEditMangacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 358);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(lConf);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbSnippet);
            Controls.Add(tbUrl);
            Controls.Add(label3);
            Controls.Add(TbDesc);
            Controls.Add(btnEdit);
            Controls.Add(label2);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditMangacs";
            Text = "FormEditMangacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label lConf;
        private Label label5;
        private Label label4;
        private RichTextBox tbSnippet;
        private TextBox tbUrl;
        private Label label3;
        private RichTextBox TbDesc;
        private Button btnEdit;
        private Label label2;
        private TextBox tbTitle;
        private Label label1;
        private Button btnCancel;
    }
}