
namespace House_Project2
{
    partial class ChangeUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUsersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.usernameDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Потребителско име:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(73, 146);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(143, 21);
            this.roleComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Роля:";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(353, 29);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(113, 30);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Промяна";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(353, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 30);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(436, 141);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 29);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(353, 141);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(30, 29);
            this.prevButton.TabIndex = 9;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.AutoSize = true;
            this.lastNameDataLabel.Location = new System.Drawing.Point(108, 59);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(0, 13);
            this.lastNameDataLabel.TabIndex = 16;
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.AutoSize = true;
            this.firstNameDataLabel.Location = new System.Drawing.Point(108, 29);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(0, 13);
            this.firstNameDataLabel.TabIndex = 15;
            // 
            // usernameDataLabel
            // 
            this.usernameDataLabel.AutoSize = true;
            this.usernameDataLabel.Location = new System.Drawing.Point(158, 98);
            this.usernameDataLabel.Name = "usernameDataLabel";
            this.usernameDataLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameDataLabel.TabIndex = 17;
            // 
            // ChangeUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 195);
            this.Controls.Add(this.usernameDataLabel);
            this.Controls.Add(this.lastNameDataLabel);
            this.Controls.Add(this.firstNameDataLabel);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUsersForm";
            this.Text = "Промяна на потребители";
            this.Load += new System.EventHandler(this.ChangeUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label usernameDataLabel;
    }
}