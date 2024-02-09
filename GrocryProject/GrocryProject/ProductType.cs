using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GrocryProject
{
    public partial class ProductType : Form
    {
        

        public ProductType()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertProdctTypeData();
        }
        private void InsertProdctTypeData()
        {
            BLLProductType bLLProduct = new BLLProductType();
            bLLProduct.ProductTypeBLL = textBox2.Text;
            int row_effected=bLLProduct.BllInsertProductType();

            if(row_effected>0)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            else
                MessageBox.Show("Something Error Happend!");
           

        }
    }
}
