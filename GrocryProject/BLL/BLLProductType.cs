using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class BLLProductType
    {
        string _productTypeBLL;
        public string ProductTypeBLL { get => _productTypeBLL; set => _productTypeBLL = value; }
        public int BllInsertProductType()
        {
            DALProductType productType = new DALProductType();
            productType.ProductType = _productTypeBLL;
            int roeEffected=productType.InsertProductType();
            return roeEffected;
        }
    }
}
