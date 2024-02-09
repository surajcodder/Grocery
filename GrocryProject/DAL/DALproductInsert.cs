using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class DALproductInsert
    {
        string _LoadProductType;

        public string LoadProductType { get => _LoadProductType; set => _LoadProductType = value; }

        public List<string> DALloadProductTypeData()
        {
            List<string> ProductTypeName = new List<string>();
            string CS=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(CS);
                SqlCommand command = new SqlCommand("LoadProductTypeData",Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    string PTypeName = reader["ProductTypeName"].ToString();
                    string PTypeId = reader["ProductTypeId"].ToString();
                    ProductTypeName.Add(PTypeName + "(" + PTypeId + ")");
                }
                return ProductTypeName;

            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }

    }

}
