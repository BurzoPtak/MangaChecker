namespace MangaChecker
{
    partial class FormView
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
            FlowPanelItems = new FlowLayoutPanel();
            mangaItem1 = new MangaItem();
            FlowPanelItems.SuspendLayout();
            SuspendLayout();
            // 
            // FlowPanelItems
            // 
            FlowPanelItems.AutoScroll = true;
            FlowPanelItems.Controls.Add(mangaItem1);
            FlowPanelItems.Location = new Point(0, -1);
            FlowPanelItems.Name = "FlowPanelItems";
            FlowPanelItems.Size = new Size(660, 358);
            FlowPanelItems.TabIndex = 0;
            // 
            // mangaItem1
            // 
            mangaItem1.BorderStyle = BorderStyle.FixedSingle;
            mangaItem1.Description = null;
            mangaItem1.Location = new Point(3, 3);
            mangaItem1.Name = "mangaItem1";
            mangaItem1.Size = new Size(645, 119);
            mangaItem1.TabIndex = 0;
            mangaItem1.Title = "";
            mangaItem1.Url = null;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 358);
            Controls.Add(FlowPanelItems);
            Name = "FormView";
            Text = "FormView";
            Controls.SetChildIndex(FlowPanelItems, 0);
            FlowPanelItems.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FlowPanelItems;
        private MangaItem mangaItem1;
    }
}