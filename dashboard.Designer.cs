using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new Panel();
            this.txttitle = new Label();
            this.btdashboard = new Button();
            this.btproducts = new Button();
            this.dashlogout = new Button();
            this.txtwelcome = new Label();
            this.cardproducts = new Panel();
            this.txtproductstitle = new Label();
            this.txtproductsvalue = new Label();
            this.cardstock = new Panel();
            this.txtstocktitle = new Label();
            this.txtstockvalue = new Label();
            this.cardlow = new Panel();
            this.txtlowtitle = new Label();
            this.txtlowvalue = new Label();
            this.cardvalue = new Panel();
            this.txtvaluetitle = new Label();
            this.txtinvvalue = new Label();
            this.txtlowlabel = new Label();
            this.txtactivitylabel = new Label();
            this.dgvlowstock = new DataGridView();
            this.dgvactivity = new DataGridView();
            ((ISupportInitialize)(this.dgvlowstock)).BeginInit();
            ((ISupportInitialize)(this.dgvactivity)).BeginInit();
            this.panel1.SuspendLayout();
            this.cardproducts.SuspendLayout();
            this.cardstock.SuspendLayout();
            this.cardlow.SuspendLayout();
            this.cardvalue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Controls.Add(this.btdashboard);
            this.panel1.Controls.Add(this.btproducts);
            this.panel1.Controls.Add(this.dashlogout);
            this.panel1.BackColor = SystemColors.HotTrack;
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Size = new Size(1449, 70);
            this.panel1.TabIndex = 0;
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.BackColor = Color.Transparent;
            this.txttitle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = Color.White;
            this.txttitle.Location = new Point(20, 17);
            this.txttitle.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.txttitle.TabIndex = 0;
            // 
            // btdashboard
            // 
            this.btdashboard.BackColor = Color.MidnightBlue;
            this.btdashboard.Cursor = Cursors.Hand;
            this.btdashboard.FlatAppearance.BorderSize = 0;
            this.btdashboard.FlatStyle = FlatStyle.Flat;
            this.btdashboard.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btdashboard.ForeColor = Color.White;
            this.btdashboard.Location = new Point(700, 12);
            this.btdashboard.Size = new Size(170, 46);
            this.btdashboard.Text = "Dashboard";
            this.btdashboard.UseVisualStyleBackColor = false;
            this.btdashboard.TabIndex = 1;
            this.btdashboard.Click += new EventHandler(this.btdashboard_Click);
            // 
            // btproducts
            // 
            this.btproducts.BackColor = SystemColors.HotTrack;
            this.btproducts.Cursor = Cursors.Hand;
            this.btproducts.FlatAppearance.BorderSize = 0;
            this.btproducts.FlatStyle = FlatStyle.Flat;
            this.btproducts.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btproducts.ForeColor = Color.White;
            this.btproducts.Location = new Point(885, 12);
            this.btproducts.Size = new Size(170, 46);
            this.btproducts.Text = "Products";
            this.btproducts.UseVisualStyleBackColor = false;
            this.btproducts.TabIndex = 2;
            this.btproducts.Click += new EventHandler(this.btproducts_Click);
            // 
            // dashlogout
            // 
            this.dashlogout.BackColor = Color.Firebrick;
            this.dashlogout.Cursor = Cursors.Hand;
            this.dashlogout.FlatAppearance.BorderSize = 0;
            this.dashlogout.FlatStyle = FlatStyle.Flat;
            this.dashlogout.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dashlogout.ForeColor = Color.White;
            this.dashlogout.Location = new Point(1240, 12);
            this.dashlogout.Size = new Size(170, 46);
            this.dashlogout.Text = "Log out";
            this.dashlogout.UseVisualStyleBackColor = false;
            this.dashlogout.TabIndex = 3;
            this.dashlogout.Click += new EventHandler(this.dashlogout_Click);
            // 
            // txtwelcome
            // 
            this.txtwelcome.AutoSize = true;
            this.txtwelcome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcome.Location = new Point(20, 85);
            this.txtwelcome.Text = "Welcome";
            this.txtwelcome.TabIndex = 1;
            // 
            // cardproducts
            // 
            this.cardproducts.Controls.Add(this.txtproductstitle);
            this.cardproducts.Controls.Add(this.txtproductsvalue);
            this.cardproducts.BackColor = Color.SteelBlue;
            this.cardproducts.Location = new Point(20, 125);
            this.cardproducts.Size = new Size(330, 110);
            this.cardproducts.TabIndex = 2;
            // 
            // txtproductstitle
            // 
            this.txtproductstitle.AutoSize = true;
            this.txtproductstitle.BackColor = Color.Transparent;
            this.txtproductstitle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtproductstitle.ForeColor = Color.White;
            this.txtproductstitle.Location = new Point(15, 12);
            this.txtproductstitle.Text = "Total Products";
            this.txtproductstitle.TabIndex = 0;
            // 
            // txtproductsvalue
            // 
            this.txtproductsvalue.AutoSize = true;
            this.txtproductsvalue.BackColor = Color.Transparent;
            this.txtproductsvalue.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtproductsvalue.ForeColor = Color.White;
            this.txtproductsvalue.Location = new Point(15, 52);
            this.txtproductsvalue.Text = "0";
            this.txtproductsvalue.TabIndex = 1;
            // 
            // cardstock
            // 
            this.cardstock.Controls.Add(this.txtstocktitle);
            this.cardstock.Controls.Add(this.txtstockvalue);
            this.cardstock.BackColor = Color.SeaGreen;
            this.cardstock.Location = new Point(372, 125);
            this.cardstock.Size = new Size(330, 110);
            this.cardstock.TabIndex = 3;
            // 
            // txtstocktitle
            // 
            this.txtstocktitle.AutoSize = true;
            this.txtstocktitle.BackColor = Color.Transparent;
            this.txtstocktitle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtstocktitle.ForeColor = Color.White;
            this.txtstocktitle.Location = new Point(15, 12);
            this.txtstocktitle.Text = "Total Stock (Units)";
            this.txtstocktitle.TabIndex = 0;
            // 
            // txtstockvalue
            // 
            this.txtstockvalue.AutoSize = true;
            this.txtstockvalue.BackColor = Color.Transparent;
            this.txtstockvalue.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtstockvalue.ForeColor = Color.White;
            this.txtstockvalue.Location = new Point(15, 52);
            this.txtstockvalue.Text = "0";
            this.txtstockvalue.TabIndex = 1;
            // 
            // cardlow
            // 
            this.cardlow.Controls.Add(this.txtlowtitle);
            this.cardlow.Controls.Add(this.txtlowvalue);
            this.cardlow.BackColor = Color.Firebrick;
            this.cardlow.Location = new Point(724, 125);
            this.cardlow.Size = new Size(330, 110);
            this.cardlow.TabIndex = 4;
            // 
            // txtlowtitle
            // 
            this.txtlowtitle.AutoSize = true;
            this.txtlowtitle.BackColor = Color.Transparent;
            this.txtlowtitle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtlowtitle.ForeColor = Color.White;
            this.txtlowtitle.Location = new Point(15, 12);
            this.txtlowtitle.Text = "Low Stock Items";
            this.txtlowtitle.TabIndex = 0;
            // 
            // txtlowvalue
            // 
            this.txtlowvalue.AutoSize = true;
            this.txtlowvalue.BackColor = Color.Transparent;
            this.txtlowvalue.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtlowvalue.ForeColor = Color.White;
            this.txtlowvalue.Location = new Point(15, 52);
            this.txtlowvalue.Text = "0";
            this.txtlowvalue.TabIndex = 1;
            // 
            // cardvalue
            // 
            this.cardvalue.Controls.Add(this.txtvaluetitle);
            this.cardvalue.Controls.Add(this.txtinvvalue);
            this.cardvalue.BackColor = Color.DarkOrange;
            this.cardvalue.Location = new Point(1076, 125);
            this.cardvalue.Size = new Size(330, 110);
            this.cardvalue.TabIndex = 5;
            // 
            // txtvaluetitle
            // 
            this.txtvaluetitle.AutoSize = true;
            this.txtvaluetitle.BackColor = Color.Transparent;
            this.txtvaluetitle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtvaluetitle.ForeColor = Color.White;
            this.txtvaluetitle.Location = new Point(15, 12);
            this.txtvaluetitle.Text = "Inventory Value";
            this.txtvaluetitle.TabIndex = 0;
            // 
            // txtinvvalue
            // 
            this.txtinvvalue.AutoSize = true;
            this.txtinvvalue.BackColor = Color.Transparent;
            this.txtinvvalue.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtinvvalue.ForeColor = Color.White;
            this.txtinvvalue.Location = new Point(15, 52);
            this.txtinvvalue.Text = "0";
            this.txtinvvalue.TabIndex = 1;
            // 
            // txtlowlabel
            // 
            this.txtlowlabel.AutoSize = true;
            this.txtlowlabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtlowlabel.Location = new Point(20, 250);
            this.txtlowlabel.Text = "Low Stock Products";
            this.txtlowlabel.TabIndex = 6;
            // 
            // txtactivitylabel
            // 
            this.txtactivitylabel.AutoSize = true;
            this.txtactivitylabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtactivitylabel.Location = new Point(740, 250);
            this.txtactivitylabel.Text = "Recent Activity";
            this.txtactivitylabel.TabIndex = 7;
            // 
            // dgvlowstock
            // 
            this.dgvlowstock.AllowUserToAddRows = false;
            this.dgvlowstock.AllowUserToDeleteRows = false;
            this.dgvlowstock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlowstock.BackgroundColor = Color.White;
            this.dgvlowstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlowstock.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dgvlowstock.Location = new Point(20, 285);
            this.dgvlowstock.MultiSelect = false;
            this.dgvlowstock.ReadOnly = true;
            this.dgvlowstock.RowHeadersVisible = false;
            this.dgvlowstock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvlowstock.Size = new Size(700, 430);
            this.dgvlowstock.TabIndex = 8;
            // 
            // dgvactivity
            // 
            this.dgvactivity.AllowUserToAddRows = false;
            this.dgvactivity.AllowUserToDeleteRows = false;
            this.dgvactivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvactivity.BackgroundColor = Color.White;
            this.dgvactivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactivity.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dgvactivity.Location = new Point(740, 285);
            this.dgvactivity.MultiSelect = false;
            this.dgvactivity.ReadOnly = true;
            this.dgvactivity.RowHeadersVisible = false;
            this.dgvactivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvactivity.Size = new Size(666, 430);
            this.dgvactivity.TabIndex = 9;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1449, 737);
            this.Controls.Add(this.dgvactivity);
            this.Controls.Add(this.dgvlowstock);
            this.Controls.Add(this.txtactivitylabel);
            this.Controls.Add(this.txtlowlabel);
            this.Controls.Add(this.cardvalue);
            this.Controls.Add(this.cardlow);
            this.Controls.Add(this.cardstock);
            this.Controls.Add(this.cardproducts);
            this.Controls.Add(this.txtwelcome);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new EventHandler(this.dashboard_Load);
            this.FormClosed += new FormClosedEventHandler(this.dashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cardproducts.ResumeLayout(false);
            this.cardproducts.PerformLayout();
            this.cardstock.ResumeLayout(false);
            this.cardstock.PerformLayout();
            this.cardlow.ResumeLayout(false);
            this.cardlow.PerformLayout();
            this.cardvalue.ResumeLayout(false);
            this.cardvalue.PerformLayout();
            ((ISupportInitialize)(this.dgvlowstock)).EndInit();
            ((ISupportInitialize)(this.dgvactivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label txttitle;
        private Button btdashboard;
        private Button btproducts;
        private Button dashlogout;
        private Label txtwelcome;
        private Panel cardproducts;
        private Label txtproductstitle;
        private Label txtproductsvalue;
        private Panel cardstock;
        private Label txtstocktitle;
        private Label txtstockvalue;
        private Panel cardlow;
        private Label txtlowtitle;
        private Label txtlowvalue;
        private Panel cardvalue;
        private Label txtvaluetitle;
        private Label txtinvvalue;
        private Label txtlowlabel;
        private Label txtactivitylabel;
        private DataGridView dgvlowstock;
        private DataGridView dgvactivity;
    }
}
