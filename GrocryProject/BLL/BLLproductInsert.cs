using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLproductInsert
    {
        public List<string>GetProductTypeName()
        {
            DAL.DALproductInsert productTName = new DALproductInsert();
            return productTName.DALloadProductTypeData();
        }
    }
}
