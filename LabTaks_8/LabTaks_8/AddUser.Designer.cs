namespace LabTaks_8
{
    partial class AddUser
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
            this.AddUserButton1 = new System.Windows.Forms.Button();
            this.EditUserbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserButton1
            // 
            this.AddUserButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserButton1.Location = new System.Drawing.Point(136, 129);
            this.AddUserButton1.Name = "AddUserButton1";
            this.AddUserButton1.Size = new System.Drawing.Size(238, 81);
            this.AddUserButton1.TabIndex = 0;
            this.AddUserButton1.Text = "Add User";
            this.AddUserButton1.UseVisualStyleBackColor = true;
            this.AddUserButton1.Click += new System.EventHandler(this.AddUserButton1_Click);
            // 
            // EditUserbutton2
            // 
            this.EditUserbutton2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserbutton2.Location = new System.Drawing.Point(452, 129);
            this.EditUserbutton2.Name = "EditUserbutton2";
            this.EditUserbutton2.Size = new System.Drawing.Size(224, 81);
            this.EditUserbutton2.TabIndex = 1;
            this.EditUserbutton2.Text = "Edit User";
            this.EditUserbutton2.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditUserbutton2);
            this.Controls.Add(this.AddUserButton1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton1;
        private System.Windows.Forms.Button EditUserbutton2;
    }
}