﻿using System;
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
    public partial class ProductDetailsInsert : Form
    {
        public ProductDetailsInsert()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUiProductTypeName();
        }
        private void GetUiProductTypeName()
        {
            BLLproductInsert bLLproduct = new BLLproductInsert();
            List<string> PTypeNames = bLLproduct.GetProductTypeName();
            foreach(string PTypeName in PTypeNames)
            {
                cmbInsertProductType.Items.Add(PTypeName);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
