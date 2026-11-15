using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace Inventory
{
    public partial class ProductForm : Form
    {
        int selectedId = 0;   // 0 = no product selected

        public ProductForm()
        {
            InitializeComponent();
            cboCategory.Items.AddRange(new string[] { "Smartphone", "Tablet", "Accessories", "Charger", "Case", "Earphones" });
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts("");
        }

        // ---------- READ ----------
        private void LoadProducts(string keyword)
        {
            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();
                    string query = "SELECT product_id, product_name, category, cpu, ram, storage, unit_price, quantity, reorder_level, description, created_at " +
                                   "FROM products WHERE product_name LIKE @k OR category LIKE @k OR cpu LIKE @k ORDER BY product_id DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
                        DataTable dt = new DataTable();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dgvProducts.DataSource = dt;
                    }
                }

                // highlight low stock rows
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (Convert.ToInt32(row.Cells["quantity"].Value) <= Convert.ToInt32(row.Cells["reorder_level"].Value))
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- CREATE ----------
        private void btadd_Click(object sender, EventArgs e)
        {
            if (!CheckInputs()) return;

            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO products (product_name, category, cpu, ram, storage, description, unit_price, quantity, reorder_level) " +
                                   "VALUES (@name, @category, @cpu, @ram, @storage, @desc, @price, @qty, @reorder)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        AddParameters(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                Log("ADD PRODUCT", txtName.Text.Trim());
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadProducts("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- UPDATE ----------
        private void btupdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product from the table first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckInputs()) return;

            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE products SET product_name=@name, category=@category, cpu=@cpu, ram=@ram, storage=@storage, " +
                                   "description=@desc, unit_price=@price, quantity=@qty, reorder_level=@reorder WHERE product_id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        AddParameters(cmd);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }
                Log("UPDATE PRODUCT", "ID " + selectedId + " - " + txtName.Text.Trim());
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadProducts("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- DELETE ----------
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product from the table first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE product_id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }
                Log("DELETE PRODUCT", "ID " + selectedId + " - " + txtName.Text.Trim());
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadProducts("");
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                // foreign key error: product is used in stock_transactions
                MessageBox.Show("This product already has stock transactions, so it cannot be deleted.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- OTHER BUTTONS ----------
        private void btclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["product_id"].Value);
            txtName.Text = row.Cells["product_name"].Value.ToString();
            cboCategory.Text = row.Cells["category"].Value.ToString();
            txtCpu.Text = row.Cells["cpu"].Value.ToString();
            txtRam.Text = row.Cells["ram"].Value.ToString();
            txtStorage.Text = row.Cells["storage"].Value.ToString();
            txtPrice.Text = row.Cells["unit_price"].Value.ToString();
            txtQty.Text = row.Cells["quantity"].Value.ToString();
            txtReorder.Text = row.Cells["reorder_level"].Value.ToString();
            txtDesc.Text = row.Cells["description"].Value.ToString();
        }

        // ---------- HELPER METHODS ----------
        private bool CheckInputs()
        {
            if (txtName.Text.Trim() == "" || cboCategory.Text.Trim() == "")
            {
                MessageBox.Show("Product name and category are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal price;
            int qty, reorder;
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0 ||
                !int.TryParse(txtQty.Text, out qty) || qty < 0 ||
                !int.TryParse(txtReorder.Text, out reorder) || reorder < 0)
            {
                MessageBox.Show("Price, quantity and reorder level must be valid positive numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AddParameters(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@category", cboCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@cpu", txtCpu.Text.Trim());
            cmd.Parameters.AddWithValue("@ram", txtRam.Text.Trim());
            cmd.Parameters.AddWithValue("@storage", txtStorage.Text.Trim());
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text.Trim());
            cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
            cmd.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
        }

        private void ClearFields()
        {
            selectedId = 0;
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = "";
            txtCpu.Clear();
            txtRam.Clear();
            txtStorage.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtReorder.Clear();
            txtDesc.Clear();
            txtName.Focus();
        }

        // saves who did what into the activity_log table
        private void Log(string action, string details)
        {
            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO activity_log (username, action_name, details) VALUES (@u, @a, @d)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", UserSession.Username);
                        cmd.Parameters.AddWithValue("@a", action);
                        cmd.Parameters.AddWithValue("@d", details);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }
    }
}
