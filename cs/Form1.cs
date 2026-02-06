using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cs
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var price = numPrice.Value;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Inserire un nome prodotto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Prodotto già presente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            products.Add(new Product { Name = name, Price = price });
            ClearInputs();
            RefreshList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Inserire il nome del prodotto da modificare nel campo cerca.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = products.FirstOrDefault(p => p.Name.Equals(search, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                MessageBox.Show("Prodotto non trovato.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newName = txtName.Text.Trim();
            var newPrice = numPrice.Value;

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Inserire un nuovo nome per il prodotto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if changing name to another existing product's name
            if (!product.Name.Equals(newName, StringComparison.OrdinalIgnoreCase) && products.Any(p => p.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Un altro prodotto con lo stesso nome esiste già.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            product.Name = newName;
            product.Price = newPrice;
            ClearInputs();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Inserire il nome del prodotto da cancellare nel campo cerca.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = products.FirstOrDefault(p => p.Name.Equals(search, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                MessageBox.Show("Prodotto non trovato.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show($"Confermi la cancellazione di '{product.Name}'?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                products.Remove(product);
                ClearInputs();
                RefreshList();
            }
        }

        private void lstProducts_DoubleClick(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is Product p)
            {
                txtName.Text = p.Name;
                numPrice.Value = p.Price;
                txtSearch.Text = p.Name;
            }
        }

        private void RefreshList()
        {
            lstProducts.Items.Clear();
            foreach (var p in products)
            {
                lstProducts.Items.Add(p);
            }
        }

        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            numPrice.Value = 0;
            txtSearch.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C2}";
        }
    }
}
