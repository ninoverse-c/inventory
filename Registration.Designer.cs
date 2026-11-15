namespace Inventory
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linksignin = new System.Windows.Forms.LinkLabel();
            this.btregister = new System.Windows.Forms.Button();
            this.txtdecscreate = new System.Windows.Forms.Label();
            this.tbrepassr = new System.Windows.Forms.TextBox();
            this.tbpassr = new System.Windows.Forms.TextBox();
            this.tbuseridr = new System.Windows.Forms.TextBox();
            this.tbfnr = new System.Windows.Forms.TextBox();
            this.reenterpassr = new System.Windows.Forms.Label();
            this.txtPassr = new System.Windows.Forms.Label();
            this.txtuseridr = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linksignin);
            this.panel1.Controls.Add(this.btregister);
            this.panel1.Controls.Add(this.txtdecscreate);
            this.panel1.Controls.Add(this.tbrepassr);
            this.panel1.Controls.Add(this.tbpassr);
            this.panel1.Controls.Add(this.tbuseridr);
            this.panel1.Controls.Add(this.tbfnr);
            this.panel1.Controls.Add(this.reenterpassr);
            this.panel1.Controls.Add(this.txtPassr);
            this.panel1.Controls.Add(this.txtuseridr);
            this.panel1.Controls.Add(this.txtfn);
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Location = new System.Drawing.Point(261, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 567);
            this.panel1.TabIndex = 0;
            // 
            // linksignin
            // 
            this.linksignin.AutoSize = true;
            this.linksignin.Location = new System.Drawing.Point(365, 518);
            this.linksignin.Name = "linksignin";
            this.linksignin.Size = new System.Drawing.Size(290, 20);
            this.linksignin.TabIndex = 13;
            this.linksignin.TabStop = true;
            this.linksignin.Text = "I have already an account. Sign in here..";
            this.linksignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksignin_LinkClicked);
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.SystemColors.Highlight;
            this.btregister.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btregister.Location = new System.Drawing.Point(410, 446);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(209, 44);
            this.btregister.TabIndex = 12;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // txtdecscreate
            // 
            this.txtdecscreate.AutoSize = true;
            this.txtdecscreate.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdecscreate.Location = new System.Drawing.Point(406, 129);
            this.txtdecscreate.Name = "txtdecscreate";
            this.txtdecscreate.Size = new System.Drawing.Size(128, 20);
            this.txtdecscreate.TabIndex = 11;
            this.txtdecscreate.Text = "Create your account";
            // 
            // tbrepassr
            // 
            this.tbrepassr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrepassr.Location = new System.Drawing.Point(345, 382);
            this.tbrepassr.Name = "tbrepassr";
            this.tbrepassr.PasswordChar = '*';
            this.tbrepassr.Size = new System.Drawing.Size(386, 35);
            this.tbrepassr.TabIndex = 10;
            // 
            // tbpassr
            // 
            this.tbpassr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassr.Location = new System.Drawing.Point(345, 309);
            this.tbpassr.Name = "tbpassr";
            this.tbpassr.PasswordChar = '*';
            this.tbpassr.Size = new System.Drawing.Size(386, 35);
            this.tbpassr.TabIndex = 9;
            // 
            // tbuseridr
            // 
            this.tbuseridr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuseridr.Location = new System.Drawing.Point(345, 233);
            this.tbuseridr.Name = "tbuseridr";
            this.tbuseridr.Size = new System.Drawing.Size(386, 35);
            this.tbuseridr.TabIndex = 8;
            // 
            // tbfnr
            // 
            this.tbfnr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfnr.Location = new System.Drawing.Point(345, 156);
            this.tbfnr.Name = "tbfnr";
            this.tbfnr.Size = new System.Drawing.Size(386, 35);
            this.tbfnr.TabIndex = 7;
            // 
            // reenterpassr
            // 
            this.reenterpassr.AutoSize = true;
            this.reenterpassr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterpassr.Location = new System.Drawing.Point(106, 390);
            this.reenterpassr.Name = "reenterpassr";
            this.reenterpassr.Size = new System.Drawing.Size(224, 27);
            this.reenterpassr.TabIndex = 6;
            this.reenterpassr.Text = "Re-enter Password:";
            // 
            // txtPassr
            // 
            this.txtPassr.AutoSize = true;
            this.txtPassr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassr.Location = new System.Drawing.Point(186, 317);
            this.txtPassr.Name = "txtPassr";
            this.txtPassr.Size = new System.Drawing.Size(124, 27);
            this.txtPassr.TabIndex = 5;
            this.txtPassr.Text = "Password:";
            // 
            // txtuseridr
            // 
            this.txtuseridr.AutoSize = true;
            this.txtuseridr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuseridr.Location = new System.Drawing.Point(186, 241);
            this.txtuseridr.Name = "txtuseridr";
            this.txtuseridr.Size = new System.Drawing.Size(129, 27);
            this.txtuseridr.TabIndex = 4;
            this.txtuseridr.Text = "Username:";
            // 
            // txtfn
            // 
            this.txtfn.AutoSize = true;
            this.txtfn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(195, 164);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(120, 27);
            this.txtfn.TabIndex = 3;
            this.txtfn.Text = "Fullname:";
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txttitle.Location = new System.Drawing.Point(208, 36);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(523, 82);
            this.txttitle.TabIndex = 1;
            this.txttitle.Text = "INVENTORY MANAGEMENT \r\nSYSTEM";
            this.txttitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory.Properties.Resources.bgs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1449, 737);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txttitle;
        private System.Windows.Forms.Label reenterpassr;
        private System.Windows.Forms.Label txtPassr;
        private System.Windows.Forms.Label txtuseridr;
        private System.Windows.Forms.Label txtfn;
        private System.Windows.Forms.Label txtdecscreate;
        private System.Windows.Forms.TextBox tbrepassr;
        private System.Windows.Forms.TextBox tbpassr;
        private System.Windows.Forms.TextBox tbuseridr;
        private System.Windows.Forms.TextBox tbfnr;
        private System.Windows.Forms.LinkLabel linksignin;
        private System.Windows.Forms.Button btregister;
    }
}