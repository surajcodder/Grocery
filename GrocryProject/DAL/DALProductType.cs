using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DALProductType
    {
        string _productType;
        public string ProductType { get => _productType; set => _productType = value; }

        public int InsertProductType()
        {
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spInsertProductTypeData", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ProductTypeName", _productType);
                sqlConnection.Open();
                RowsEffected= sqlCommand.ExecuteNonQuery();
                return RowsEffected;
            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
