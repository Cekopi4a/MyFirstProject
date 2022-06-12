
namespace House_Project2
{
    partial class chouseHouse
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
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CatComboBox = new System.Windows.Forms.ComboBox();
            this.TownComboBox = new System.Windows.Forms.ComboBox();
            this.houseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filtersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(642, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Town:";
            // 
            // CatComboBox
            // 
            this.CatComboBox.FormattingEnabled = true;
            this.CatComboBox.Location = new System.Drawing.Point(22, 54);
            this.CatComboBox.Name = "CatComboBox";
            this.CatComboBox.Size = new System.Drawing.Size(169, 21);
            this.CatComboBox.TabIndex = 2;
            this.CatComboBox.SelectedIndexChanged += new System.EventHandler(this.CatComboBox_SelectedIndexChanged);
            // 
            // TownComboBox
            // 
            this.TownComboBox.FormattingEnabled = true;
            this.TownComboBox.Location = new System.Drawing.Point(645, 54);
            this.TownComboBox.Name = "TownComboBox";
            this.TownComboBox.Size = new System.Drawing.Size(185, 21);
            this.TownComboBox.TabIndex = 3;
            this.TownComboBox.SelectedIndexChanged += new System.EventHandler(this.TownComboBox_SelectedIndexChanged);
            // 
            // houseListView
            // 
            this.houseListView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.houseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            listViewGroup13.Header = "ListViewGroup";
            listViewGroup13.Name = "listViewGroup1";
            listViewGroup14.Header = "ListViewGroup";
            listViewGroup14.Name = "listViewGroup2";
            listViewGroup15.Header = "ListViewGroup";
            listViewGroup15.Name = "listViewGroup3";
            listViewGroup16.Header = "ListViewGroup";
            listViewGroup16.Name = "listViewGroup4";
            listViewGroup17.Header = "ListViewGroup";
            listViewGroup17.Name = "listViewGroup5";
            listViewGroup18.Header = "ListViewGroup";
            listViewGroup18.Name = "listViewGroup6";
            this.houseListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
            this.houseListView.HideSelection = false;
            this.houseListView.Location = new System.Drawing.Point(22, 90);
            this.houseListView.Name = "houseListView";
            this.houseListView.Size = new System.Drawing.Size(808, 384);
            this.houseListView.TabIndex = 4;
            this.houseListView.UseCompatibleStateImageBehavior = false;
            this.houseListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имот";
            this.columnHeader1.Width = 333;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Населено място";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            this.columnHeader4.Width = 207;
            // 
            // filtersButton
            // 
            this.filtersButton.BackColor = System.Drawing.SystemColors.Control;
            this.filtersButton.BackgroundImage = global::House_Project2.Properties.Resources.locked;
            this.filtersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filtersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtersButton.Location = new System.Drawing.Point(389, 31);
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(46, 46);
            this.filtersButton.TabIndex = 5;
            this.filtersButton.UseVisualStyleBackColor = true;
            this.filtersButton.Click += new System.EventHandler(this.filtersButton_Click);
            // 
            // chouseHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 507);
            this.Controls.Add(this.filtersButton);
            this.Controls.Add(this.houseListView);
            this.Controls.Add(this.TownComboBox);
            this.Controls.Add(this.CatComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chouseHouse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Избор на имот";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveCaption;
            this.Load += new System.EventHandler(this.chouseHouse_Load);
            this.VisibleChanged += new System.EventHandler(this.chouseHouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CatComboBox;
        private System.Windows.Forms.ComboBox TownComboBox;
        private System.Windows.Forms.ListView houseListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button filtersButton;
    }
}