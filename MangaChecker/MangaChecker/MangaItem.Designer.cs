namespace MangaChecker
{
    partial class MangaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lItemTitle = new Label();
            lDesc = new Label();
            btnItemEdit = new Button();
            lItemUrl = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lItemTitle
            // 
            lItemTitle.AutoSize = true;
            lItemTitle.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lItemTitle.Location = new Point(92, 12);
            lItemTitle.Name = "lItemTitle";
            lItemTitle.Size = new Size(65, 25);
            lItemTitle.TabIndex = 0;
            lItemTitle.Text = "label1";
            lItemTitle.MouseHover += lItemTitle_Hover;
            // 
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Location = new Point(165, 61);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(67, 15);
            lDesc.TabIndex = 4;
            lDesc.Text = "Description";
            lDesc.MouseHover += lDesc_Hover;
            // 
            // btnItemEdit
            // 
            btnItemEdit.Location = new Point(424, 12);
            btnItemEdit.Name = "btnItemEdit";
            btnItemEdit.Size = new Size(75, 23);
            btnItemEdit.TabIndex = 5;
            btnItemEdit.Text = "Edit";
            btnItemEdit.UseVisualStyleBackColor = true;
            btnItemEdit.Click += btnItemEdit_Click;
            // 
            // lItemUrl
            // 
            lItemUrl.AutoSize = true;
            lItemUrl.Location = new Point(123, 37);
            lItemUrl.Name = "lItemUrl";
            lItemUrl.Size = new Size(25, 15);
            lItemUrl.TabIndex = 1;
            lItemUrl.Text = "Url:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 61);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 37);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "Url:";
            // 
            // MangaItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnItemEdit);
            Controls.Add(lDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lItemUrl);
            Controls.Add(lItemTitle);
            Name = "MangaItem";
            Size = new Size(518, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lItemTitle;
        private Label lDesc;
        private Button btnItemEdit;
        private Label lItemUrl;
        private Label label1;
        private Label label2;
    }
}
