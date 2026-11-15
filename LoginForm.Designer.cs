namespace Inventory
{
    partial class LoginForm
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
            this.txttitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerlink = new System.Windows.Forms.LinkLabel();
            this.btsignin = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuserid = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txttitle.Location = new System.Drawing.Point(119, 71);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(523, 82);
            this.txttitle.TabIndex = 0;
            this.txttitle.Text = "INVENTORY MANAGEMENT \r\nSYSTEM";
            this.txttitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registerlink);
            this.panel1.Controls.Add(this.btsignin);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbuserid);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuserid);
            this.panel1.Controls.Add(this.txtdesc);
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Location = new System.Drawing.Point(364, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 624);
            this.panel1.TabIndex = 1;
            // 
            // registerlink
            // 
            this.registerlink.AutoSize = true;
            this.registerlink.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlink.Location = new System.Drawing.Point(221, 566);
            this.registerlink.Name = "registerlink";
            this.registerlink.Size = new System.Drawing.Size(281, 19);
            this.registerlink.TabIndex = 9;
            this.registerlink.TabStop = true;
            this.registerlink.Text = "don\'t have an account? Register here..";
            this.registerlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlink_LinkClicked);
            // 
            // btsignin
            // 
            this.btsignin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btsignin.BackgroundImage = global::Inventory.Properties.Resources.backgroundpage;
            this.btsignin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btsignin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsignin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btsignin.Location = new System.Drawing.Point(305, 483);
            this.btsignin.Name = "btsignin";
            this.btsignin.Size = new System.Drawing.Size(141, 49);
            this.btsignin.TabIndex = 8;
            this.btsignin.Text = "Sign In";
            this.btsignin.UseVisualStyleBackColor = false;
            this.btsignin.Click += new System.EventHandler(this.btsignin_Click);
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(120, 427);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(516, 40);
            this.tbpass.TabIndex = 7;
            // 
            // tbuserid
            // 
            this.tbuserid.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuserid.Location = new System.Drawing.Point(120, 294);
            this.tbuserid.Name = "tbuserid";
            this.tbuserid.Size = new System.Drawing.Size(516, 40);
            this.tbuserid.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(120, 380);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(143, 32);
            this.txtpass.TabIndex = 3;
            this.txtpass.Text = "Password:";
            // 
            // txtuserid
            // 
            this.txtuserid.AutoSize = true;
            this.txtuserid.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(120, 258);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(150, 32);
            this.txtuserid.TabIndex = 2;
            this.txtuserid.Text = "Username:";
            // 
            // txtdesc
            // 
            this.txtdesc.AutoSize = true;
            this.txtdesc.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(301, 176);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(145, 20);
            this.txtdesc.TabIndex = 1;
            this.txtdesc.Text = "Sign in to your account";
            this.txtdesc.Click += new System.EventHandler(this.txtdesc_Click);
            // 
            // inventoryms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory.Properties.Resources.bgs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1449, 737);
            this.Controls.Add(this.panel1);
            this.Name = "inventoryms";
            this.Text = "Inventory management system";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txttitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.Label txtuserid;
        private System.Windows.Forms.Label txtdesc;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuserid;
        private System.Windows.Forms.LinkLabel registerlink;
        private System.Windows.Forms.Button btsignin;
    }
}

