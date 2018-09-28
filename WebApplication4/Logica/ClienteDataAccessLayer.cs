using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class ClienteDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        public IEnumerable<Cliente> GetAllClientes() {
            List<Cliente> listaClientes = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("GetClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Cliente cliente = new Cliente(Convert.ToInt32(rdr["Id"]), rdr["nombre"].ToString(), rdr["password"].ToString());

                    listaClientes.Add(cliente);
                }
                con.Close();
            }
            return listaClientes;
        }
    }
}
