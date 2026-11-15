using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    partial class ProductForm
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
            this.panel2 = new Panel();
            this.txtdetails = new Label();
            this.txtname = new Label();
            this.tbname = new TextBox();
            this.txtcategory = new Label();
            this.cbcategory = new ComboBox();
            this.txtcpu = new Label();
            this.tbcpu = new TextBox();
            this.txtram = new Label();
            this.tbram = new TextBox();
            this.txtstorage = new Label();
            this.tbstorage = new TextBox();
            this.txtprice = new Label();
            this.tbprice = new TextBox();
            this.txtqty = new Label();
            this.tbqty = new TextBox();
            this.txtreorder = new Label();
            this.tbreorder = new TextBox();
            this.txtdesc = new Label();
            this.tbdesc = new TextBox();
            this.btadd = new Button();
            this.btupdate = new Button();
            this.btdelete = new Button();
            this.btclear = new Button();
            this.txtsearch = new Label();
            this.tbsearch = new TextBox();
            this.btsearch = new Button();
            this.dgvproducts = new DataGridView();
            ((ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btdashboard.BackColor = SystemColors.HotTrack;
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
            this.btproducts.BackColor = Color.MidnightBlue;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtdetails);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.tbname);
            this.panel2.Controls.Add(this.txtcategory);
            this.panel2.Controls.Add(this.cbcategory);
            this.panel2.Controls.Add(this.txtcpu);
            this.panel2.Controls.Add(this.tbcpu);
            this.panel2.Controls.Add(this.txtram);
            this.panel2.Controls.Add(this.tbram);
            this.panel2.Controls.Add(this.txtstorage);
            this.panel2.Controls.Add(this.tbstorage);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.tbprice);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.tbqty);
            this.panel2.Controls.Add(this.txtreorder);
            this.panel2.Controls.Add(this.tbreorder);
            this.panel2.Controls.Add(this.txtdesc);
            this.panel2.Controls.Add(this.tbdesc);
            this.panel2.Controls.Add(this.btadd);
            this.panel2.Controls.Add(this.btupdate);
            this.panel2.Controls.Add(this.btdelete);
            this.panel2.Controls.Add(this.btclear);
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Location = new Point(20, 90);
            this.panel2.Size = new Size(480, 600);
            this.panel2.TabIndex = 1;
            // 
            // txtdetails
            // 
            this.txtdetails.AutoSize = true;
            this.txtdetails.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.txtdetails.Location = new Point(15, 8);
            this.txtdetails.Text = "Product Details";
            this.txtdetails.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new Point(15, 50);
            this.txtname.Text = "Product Name:";
            this.txtname.TabIndex = 1;
            // 
            // tbname
            // 
            this.tbname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new Point(190, 45);
            this.tbname.Size = new Size(270, 35);
            this.tbname.TabIndex = 2;
            // 
            // txtcategory
            // 
            this.txtcategory.AutoSize = true;
            this.txtcategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.Location = new Point(15, 94);
            this.txtcategory.Text = "Category:";
            this.txtcategory.TabIndex = 3;
            // 
            // cbcategory
            // 
            this.cbcategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.Location = new Point(190, 89);
            this.cbcategory.Size = new Size(270, 36);
            this.cbcategory.TabIndex = 4;
            // 
            // txtcpu
            // 
            this.txtcpu.AutoSize = true;
            this.txtcpu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtcpu.Location = new Point(15, 138);
            this.txtcpu.Text = "System / CPU:";
            this.txtcpu.TabIndex = 5;
            // 
            // tbcpu
            // 
            this.tbcpu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbcpu.Location = new Point(190, 133);
            this.tbcpu.Size = new Size(270, 35);
            this.tbcpu.TabIndex = 6;
            // 
            // txtram
            // 
            this.txtram.AutoSize = true;
            this.txtram.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtram.Location = new Point(15, 182);
            this.txtram.Text = "RAM:";
            this.txtram.TabIndex = 7;
            // 
            // tbram
            // 
            this.tbram.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbram.Location = new Point(190, 177);
            this.tbram.Size = new Size(270, 35);
            this.tbram.TabIndex = 8;
            // 
            // txtstorage
            // 
            this.txtstorage.AutoSize = true;
            this.txtstorage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtstorage.Location = new Point(15, 226);
            this.txtstorage.Text = "Storage:";
            this.txtstorage.TabIndex = 9;
            // 
            // tbstorage
            // 
            this.tbstorage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbstorage.Location = new Point(190, 221);
            this.tbstorage.Size = new Size(270, 35);
            this.tbstorage.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.AutoSize = true;
            this.txtprice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new Point(15, 270);
            this.txtprice.Text = "Unit Price:";
            this.txtprice.TabIndex = 11;
            // 
            // tbprice
            // 
            this.tbprice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new Point(190, 265);
            this.tbprice.Size = new Size(270, 35);
            this.tbprice.TabIndex = 12;
            // 
            // txtqty
            // 
            this.txtqty.AutoSize = true;
            this.txtqty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new Point(15, 314);
            this.txtqty.Text = "Quantity:";
            this.txtqty.TabIndex = 13;
            // 
            // tbqty
            // 
            this.tbqty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbqty.Location = new Point(190, 309);
            this.tbqty.Size = new Size(270, 35);
            this.tbqty.TabIndex = 14;
            // 
            // txtreorder
            // 
            this.txtreorder.AutoSize = true;
            this.txtreorder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtreorder.Location = new Point(15, 358);
            this.txtreorder.Text = "Reorder Level:";
            this.txtreorder.TabIndex = 15;
            // 
            // tbreorder
            // 
            this.tbreorder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbreorder.Location = new Point(190, 353);
            this.tbreorder.Size = new Size(270, 35);
            this.tbreorder.TabIndex = 16;
            // 
            // txtdesc
            // 
            this.txtdesc.AutoSize = true;
            this.txtdesc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new Point(15, 402);
            this.txtdesc.Text = "Description:";
            this.txtdesc.TabIndex = 17;
            // 
            // tbdesc
            // 
            this.tbdesc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbdesc.Location = new Point(190, 397);
            this.tbdesc.Multiline = true;
            this.tbdesc.ScrollBars = ScrollBars.Vertical;
            this.tbdesc.Size = new Size(270, 75);
            this.tbdesc.TabIndex = 18;
            // 
            // btadd
            // 
            this.btadd.BackColor = Color.SeaGreen;
            this.btadd.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = Color.White;
            this.btadd.Location = new Point(15, 490);
            this.btadd.Size = new Size(215, 42);
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.TabIndex = 19;
            this.btadd.Click += new EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = SystemColors.Highlight;
            this.btupdate.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.ForeColor = Color.White;
            this.btupdate.Location = new Point(245, 490);
            this.btupdate.Size = new Size(215, 42);
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.TabIndex = 20;
            this.btupdate.Click += new EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = Color.Firebrick;
            this.btdelete.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = Color.White;
            this.btdelete.Location = new Point(15, 540);
            this.btdelete.Size = new Size(215, 42);
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.TabIndex = 21;
            this.btdelete.Click += new EventHandler(this.btdelete_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = Color.DimGray;
            this.btclear.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btclear.ForeColor = Color.White;
            this.btclear.Location = new Point(245, 540);
            this.btclear.Size = new Size(215, 42);
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.TabIndex = 22;
            this.btclear.Click += new EventHandler(this.btclear_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoSize = true;
            this.txtsearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new Point(520, 100);
            this.txtsearch.Text = "Search:";
            this.txtsearch.TabIndex = 2;
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new Point(610, 96);
            this.tbsearch.Size = new Size(420, 35);
            this.tbsearch.TabIndex = 3;
            // 
            // btsearch
            // 
            this.btsearch.BackColor = SystemColors.Highlight;
            this.btsearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = Color.White;
            this.btsearch.Location = new Point(1045, 94);
            this.btsearch.Size = new Size(130, 40);
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.TabIndex = 4;
            this.btsearch.Click += new EventHandler(this.btsearch_Click);
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToAddRows = false;
            this.dgvproducts.AllowUserToDeleteRows = false;
            this.dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproducts.BackgroundColor = Color.White;
            this.dgvproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dgvproducts.Location = new Point(520, 150);
            this.dgvproducts.MultiSelect = false;
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.RowHeadersVisible = false;
            this.dgvproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducts.Size = new Size(900, 540);
            this.dgvproducts.TabIndex = 5;
            this.dgvproducts.CellClick += new DataGridViewCellEventHandler(this.dgvproducts_CellClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1449, 737);
            this.Controls.Add(this.dgvproducts);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new EventHandler(this.ProductForm_Load);
            this.FormClosed += new FormClosedEventHandler(this.ProductForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label txttitle;
        private Button btdashboard;
        private Button btproducts;
        private Button dashlogout;
        private Panel panel2;
        private Label txtdetails;
        private Label txtname;
        private TextBox tbname;
        private Label txtcategory;
        private ComboBox cbcategory;
        private Label txtcpu;
        private TextBox tbcpu;
        private Label txtram;
        private TextBox tbram;
        private Label txtstorage;
        private TextBox tbstorage;
        private Label txtprice;
        private TextBox tbprice;
        private Label txtqty;
        private TextBox tbqty;
        private Label txtreorder;
        private TextBox tbreorder;
        private Label txtdesc;
        private TextBox tbdesc;
        private Button btadd;
        private Button btupdate;
        private Button btdelete;
        private Button btclear;
        private Label txtsearch;
        private TextBox tbsearch;
        private Button btsearch;
        private DataGridView dgvproducts;
    }
}
