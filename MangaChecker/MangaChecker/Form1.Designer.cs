namespace MangaChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSideLaunch = new Button();
            btnSideEdit = new Button();
            btnSideView = new Button();
            btnSideAdd = new Button();
            panel3 = new Panel();
            lbTabTitle = new Label();
            pnlContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 23, 40);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 23, 40);
            panel2.Controls.Add(btnSideLaunch);
            panel2.Controls.Add(btnSideEdit);
            panel2.Controls.Add(btnSideView);
            panel2.Controls.Add(btnSideAdd);
            panel2.Location = new Point(-2, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 403);
            panel2.TabIndex = 1;
            // 
            // btnSideLaunch
            // 
            btnSideLaunch.FlatAppearance.BorderSize = 0;
            btnSideLaunch.FlatStyle = FlatStyle.Flat;
            btnSideLaunch.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSideLaunch.ForeColor = Color.FromArgb(127, 124, 146);
            btnSideLaunch.Location = new Point(31, 284);
            btnSideLaunch.Name = "btnSideLaunch";
            btnSideLaunch.Size = new Size(77, 31);
            btnSideLaunch.TabIndex = 3;
            btnSideLaunch.Text = "Launch";
            btnSideLaunch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSideLaunch.UseVisualStyleBackColor = true;
            btnSideLaunch.Click += btnSideLaunch_Click;
            // 
            // btnSideEdit
            // 
            btnSideEdit.FlatAppearance.BorderSize = 0;
            btnSideEdit.FlatStyle = FlatStyle.Flat;
            btnSideEdit.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSideEdit.ForeColor = Color.FromArgb(127, 124, 146);
            btnSideEdit.Location = new Point(0, 96);
            btnSideEdit.Name = "btnSideEdit";
            btnSideEdit.Size = new Size(142, 31);
            btnSideEdit.TabIndex = 2;
            btnSideEdit.Text = "Edit";
            btnSideEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSideEdit.UseVisualStyleBackColor = true;
            btnSideEdit.Visible = false;
            // 
            // btnSideView
            // 
            btnSideView.FlatAppearance.BorderSize = 0;
            btnSideView.FlatStyle = FlatStyle.Flat;
            btnSideView.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSideView.ForeColor = Color.FromArgb(127, 124, 146);
            btnSideView.Location = new Point(0, 48);
            btnSideView.Name = "btnSideView";
            btnSideView.Size = new Size(142, 31);
            btnSideView.TabIndex = 1;
            btnSideView.Text = "View List";
            btnSideView.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSideView.UseVisualStyleBackColor = true;
            btnSideView.Click += btnSideView_Click;
            // 
            // btnSideAdd
            // 
            btnSideAdd.Dock = DockStyle.Top;
            btnSideAdd.FlatAppearance.BorderSize = 0;
            btnSideAdd.FlatStyle = FlatStyle.Flat;
            btnSideAdd.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSideAdd.ForeColor = Color.FromArgb(127, 124, 146);
            btnSideAdd.Location = new Point(0, 0);
            btnSideAdd.Name = "btnSideAdd";
            btnSideAdd.Size = new Size(142, 31);
            btnSideAdd.TabIndex = 0;
            btnSideAdd.Text = "Add manga";
            btnSideAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSideAdd.UseVisualStyleBackColor = true;
            btnSideAdd.Click += btnSideAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 23, 13);
            panel3.Controls.Add(lbTabTitle);
            panel3.Location = new Point(139, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 44);
            panel3.TabIndex = 2;
            // 
            // lbTabTitle
            // 
            lbTabTitle.AutoSize = true;
            lbTabTitle.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTabTitle.ForeColor = Color.FromArgb(127, 124, 146);
            lbTabTitle.Location = new Point(19, 12);
            lbTabTitle.Name = "lbTabTitle";
            lbTabTitle.Size = new Size(99, 17);
            lbTabTitle.TabIndex = 0;
            lbTabTitle.Text = "Adding manga";
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Location = new Point(140, 105);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(660, 358);
            pnlContent.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 32);
            ClientSize = new Size(800, 459);
            Controls.Add(pnlContent);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 498);
            Name = "Form1";
            Text = "MangaCkeckerSettings";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnSideAdd;
        private Button btnSideLaunch;
        private Button btnSideEdit;
        private Button btnSideView;
        private Panel panel3;
        private Label lbTabTitle;
        private Panel pnlContent;
    }
}
