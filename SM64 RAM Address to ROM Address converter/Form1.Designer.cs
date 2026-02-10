namespace SM64_RAM_Address_to_ROM_Address_converter
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
            this.lblRamAddress = new System.Windows.Forms.Label();
            this.txtRamAddress = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblRomAddress = new System.Windows.Forms.Label();
            this.txtRomAddress = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRamAddress
            // 
            this.lblRamAddress.AutoSize = true;
            this.lblRamAddress.Location = new System.Drawing.Point(30, 30);
            this.lblRamAddress.Name = "lblRamAddress";
            this.lblRamAddress.Size = new System.Drawing.Size(80, 15);
            this.lblRamAddress.TabIndex = 0;
            this.lblRamAddress.Text = "RAM Address (Hex):";
            // 
            // txtRamAddress
            // 
            this.txtRamAddress.Location = new System.Drawing.Point(30, 50);
            this.txtRamAddress.Name = "txtRamAddress";
            this.txtRamAddress.Size = new System.Drawing.Size(150, 23);
            this.txtRamAddress.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(200, 48);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 25);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblRomAddress
            // 
            this.lblRomAddress.AutoSize = true;
            this.lblRomAddress.Location = new System.Drawing.Point(30, 90);
            this.lblRomAddress.Name = "lblRomAddress";
            this.lblRomAddress.Size = new System.Drawing.Size(84, 15);
            this.lblRomAddress.TabIndex = 3;
            this.lblRomAddress.Text = "ROM Address:";
            // 
            // txtRomAddress
            // 
            this.txtRomAddress.Location = new System.Drawing.Point(30, 110);
            this.txtRomAddress.Name = "txtRomAddress";
            this.txtRomAddress.ReadOnly = true;
            this.txtRomAddress.Size = new System.Drawing.Size(150, 23);
            this.txtRomAddress.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Region Info:";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(30, 170);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(0, 15);
            this.lblDescriptionValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtRomAddress);
            this.Controls.Add(this.lblRomAddress);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtRamAddress);
            this.Controls.Add(this.lblRamAddress);
            this.Name = "Form1";
            this.Text = "SM64 RAM to ROM";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblRamAddress;
        private System.Windows.Forms.TextBox txtRamAddress;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblRomAddress;
        private System.Windows.Forms.TextBox txtRomAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionValue;

        #endregion
    }
}
