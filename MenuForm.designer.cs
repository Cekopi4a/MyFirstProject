
namespace House_Project2
{
    partial class MenuForm
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
            this.categorieGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeCategories = new System.Windows.Forms.Button();
            this.townGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeTypes = new System.Windows.Forms.Button();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeUsers = new System.Windows.Forms.Button();
            this.ReviewUsers = new System.Windows.Forms.Button();
            this.HouseBox = new System.Windows.Forms.GroupBox();
            this.ViewHouse = new System.Windows.Forms.Button();
            this.ChangeHouse = new System.Windows.Forms.Button();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categorieGroupBox.SuspendLayout();
            this.townGroupBox.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.HouseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorieGroupBox
            // 
            this.categorieGroupBox.Controls.Add(this.ChangeCategories);
            this.categorieGroupBox.Location = new System.Drawing.Point(195, 42);
            this.categorieGroupBox.Name = "categorieGroupBox";
            this.categorieGroupBox.Size = new System.Drawing.Size(117, 100);
            this.categorieGroupBox.TabIndex = 3;
            this.categorieGroupBox.TabStop = false;
            this.categorieGroupBox.Text = "Категорий";
            this.categorieGroupBox.Visible = false;
            // 
            // ChangeCategories
            // 
            this.ChangeCategories.Location = new System.Drawing.Point(20, 42);
            this.ChangeCategories.Name = "ChangeCategories";
            this.ChangeCategories.Size = new System.Drawing.Size(75, 23);
            this.ChangeCategories.TabIndex = 0;
            this.ChangeCategories.Text = "Промени";
            this.ChangeCategories.UseVisualStyleBackColor = true;
            this.ChangeCategories.Click += new System.EventHandler(this.ChangeCategories_Click);
            // 
            // townGroupBox
            // 
            this.townGroupBox.Controls.Add(this.ChangeTypes);
            this.townGroupBox.Location = new System.Drawing.Point(344, 42);
            this.townGroupBox.Name = "townGroupBox";
            this.townGroupBox.Size = new System.Drawing.Size(118, 100);
            this.townGroupBox.TabIndex = 4;
            this.townGroupBox.TabStop = false;
            this.townGroupBox.Text = "Смяна на града";
            this.townGroupBox.Visible = false;
            // 
            // ChangeTypes
            // 
            this.ChangeTypes.Location = new System.Drawing.Point(18, 42);
            this.ChangeTypes.Name = "ChangeTypes";
            this.ChangeTypes.Size = new System.Drawing.Size(75, 23);
            this.ChangeTypes.TabIndex = 0;
            this.ChangeTypes.Text = "Промени";
            this.ChangeTypes.UseVisualStyleBackColor = true;
            this.ChangeTypes.Click += new System.EventHandler(this.ChangeTypes_Click);
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.ChangeUsers);
            this.userGroupBox.Controls.Add(this.ReviewUsers);
            this.userGroupBox.Location = new System.Drawing.Point(507, 42);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(109, 100);
            this.userGroupBox.TabIndex = 5;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "Потребители";
            this.userGroupBox.Visible = false;
            // 
            // ChangeUsers
            // 
            this.ChangeUsers.Location = new System.Drawing.Point(19, 59);
            this.ChangeUsers.Name = "ChangeUsers";
            this.ChangeUsers.Size = new System.Drawing.Size(75, 23);
            this.ChangeUsers.TabIndex = 1;
            this.ChangeUsers.Text = "Промени";
            this.ChangeUsers.UseVisualStyleBackColor = true;
            this.ChangeUsers.Click += new System.EventHandler(this.ChangeUsers_Click);
            // 
            // ReviewUsers
            // 
            this.ReviewUsers.Location = new System.Drawing.Point(19, 19);
            this.ReviewUsers.Name = "ReviewUsers";
            this.ReviewUsers.Size = new System.Drawing.Size(75, 23);
            this.ReviewUsers.TabIndex = 0;
            this.ReviewUsers.Text = "Виж";
            this.ReviewUsers.UseVisualStyleBackColor = true;
            this.ReviewUsers.Click += new System.EventHandler(this.ReviewUsers_Click);
            // 
            // HouseBox
            // 
            this.HouseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HouseBox.Controls.Add(this.label1);
            this.HouseBox.Controls.Add(this.ViewHouse);
            this.HouseBox.Controls.Add(this.ChangeHouse);
            this.HouseBox.Location = new System.Drawing.Point(32, 33);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(127, 109);
            this.HouseBox.TabIndex = 2;
            this.HouseBox.TabStop = false;
            this.HouseBox.Text = "Имоти";
            // 
            // ViewHouse
            // 
            this.ViewHouse.Location = new System.Drawing.Point(26, 28);
            this.ViewHouse.Name = "ViewHouse";
            this.ViewHouse.Size = new System.Drawing.Size(75, 23);
            this.ViewHouse.TabIndex = 0;
            this.ViewHouse.Text = "Виж";
            this.ViewHouse.UseVisualStyleBackColor = true;
            this.ViewHouse.Click += new System.EventHandler(this.ViewHouse_Click);
            // 
            // ChangeHouse
            // 
            this.ChangeHouse.Location = new System.Drawing.Point(26, 80);
            this.ChangeHouse.Name = "ChangeHouse";
            this.ChangeHouse.Size = new System.Drawing.Size(75, 23);
            this.ChangeHouse.TabIndex = 1;
            this.ChangeHouse.Text = " Добави";
            this.ChangeHouse.UseVisualStyleBackColor = true;
            this.ChangeHouse.Click += new System.EventHandler(this.ChangeHouse_Click);
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUserLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameUserLabel.Location = new System.Drawing.Point(28, 9);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(0, 19);
            this.nameUserLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добави или промени:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 166);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.townGroupBox);
            this.Controls.Add(this.categorieGroupBox);
            this.Controls.Add(this.HouseBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.categorieGroupBox.ResumeLayout(false);
            this.townGroupBox.ResumeLayout(false);
            this.userGroupBox.ResumeLayout(false);
            this.HouseBox.ResumeLayout(false);
            this.HouseBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewHouse;
        private System.Windows.Forms.Button ChangeHouse;
        private System.Windows.Forms.GroupBox HouseBox;
        private System.Windows.Forms.GroupBox categorieGroupBox;
        private System.Windows.Forms.GroupBox townGroupBox;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Button ChangeCategories;
        private System.Windows.Forms.Button ChangeTypes;
        private System.Windows.Forms.Button ChangeUsers;
        private System.Windows.Forms.Button ReviewUsers;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label label1;
    }
}