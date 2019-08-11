namespace ShareAVehicle
{
    partial class VehicleOrUserWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserBtn = new System.Windows.Forms.Button();
            this.DriverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(239, 235);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(75, 23);
            this.UserBtn.TabIndex = 1;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // DriverBtn
            // 
            this.DriverBtn.Location = new System.Drawing.Point(485, 235);
            this.DriverBtn.Name = "DriverBtn";
            this.DriverBtn.Size = new System.Drawing.Size(75, 23);
            this.DriverBtn.TabIndex = 2;
            this.DriverBtn.Text = "Driver";
            this.DriverBtn.UseVisualStyleBackColor = true;
            this.DriverBtn.Click += new System.EventHandler(this.DriverBtn_Click);
            // 
            // VehicleOrUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DriverBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.label1);
            this.Name = "VehicleOrUserWindow";
            this.Text = "VehicleOrUserWindow";
            this.Load += new System.EventHandler(this.VehicleOrUserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button DriverBtn;
    }
}