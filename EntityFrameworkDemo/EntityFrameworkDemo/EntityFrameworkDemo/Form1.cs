using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProcuctDal _procuctDal = new ProcuctDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _procuctDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //var result = _procuctDal.GetAll().Where(p=>p.Name.ToLower().Contains(key)).ToList(); //collection a küçük k küçük l vs yazınca gelmiyor(c# küçük büyük duyarlı olduğu için TO LOWER EKLE BUNU YÜZDEN YA DA VERİTABANINDAN ÇEK)
            //koleksiyona filtre koyuyorum, burada where kısmına kadar olan kısımda veri tabanını sorguladım!
            var result = _procuctDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _procuctDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text)
            }) ;

            LoadProducts();

            MessageBox.Show("Added!");
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            _procuctDal.Update(new Product {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });

            LoadProducts();

            MessageBox.Show("Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();

            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _procuctDal.Delete(new Product {
            Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();

            MessageBox.Show("Deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tbxSearch.Text);
            SearchProducts(tbxSearch.Text);
        }

        private void tbxGetByID_Click(object sender, EventArgs e)
        {
            _procuctDal.GetById(1);
        }
    }
}
