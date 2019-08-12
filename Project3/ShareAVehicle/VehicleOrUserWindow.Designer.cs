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
            this.titleLbl = new System.Windows.Forms.Label();
            this.passangerDescripLbl = new System.Windows.Forms.Label();
            this.driverDescripLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(239, 235);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(75, 23);
            this.UserBtn.TabIndex = 1;
            this.UserBtn.Text = "Passenger";
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
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(321, 76);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(164, 25);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Share a Vehicle";
            // 
            // passangerDescripLbl
            // 
            this.passangerDescripLbl.AutoSize = true;
            this.passangerDescripLbl.Location = new System.Drawing.Point(211, 284);
            this.passangerDescripLbl.Name = "passangerDescripLbl";
            this.passangerDescripLbl.Size = new System.Drawing.Size(132, 13);
            this.passangerDescripLbl.TabIndex = 4;
            this.passangerDescripLbl.Text = "Can look for available cars";
            // 
            // driverDescripLbl
            // 
            this.driverDescripLbl.AutoSize = true;
            this.driverDescripLbl.Location = new System.Drawing.Point(442, 284);
            this.driverDescripLbl.Name = "driverDescripLbl";
            this.driverDescripLbl.Size = new System.Drawing.Size(172, 13);
            this.driverDescripLbl.TabIndex = 5;
            this.driverDescripLbl.Text = "Can add an available car\'s location";
            // 
            // VehicleOrUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driverDescripLbl);
            this.Controls.Add(this.passangerDescripLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.DriverBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.label1);
            this.Name = "VehicleOrUserWindow";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button DriverBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label passangerDescripLbl;
        private System.Windows.Forms.Label driverDescripLbl;
    }
}