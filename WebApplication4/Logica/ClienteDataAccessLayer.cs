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
                SqlCommand cmd = new SqlCommand("CASP_GetClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Cliente cliente = new Cliente(Convert.ToInt32(rdr["Id"]), rdr["nombre"].ToString(), rdr["password"].ToString(), false);

                    listaClientes.Add(cliente);
                }
                con.Close();
            }
            return listaClientes;
        }

        public void EditarCliente(Cliente pCliente, Administrador pAdministrador) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_ModificarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {

                }
            }

        }

        public void 

        public bool VerificarCredencialesAdmin(string pNombre, string pClave) {
            int valorVerificacion = 2; //Se le pone un valor que no sea 1 o -1 para no confundir con lo que se recibe
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_LoginAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                cmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

                while (rdr.Read()) {
                    valorVerificacion = (int)cmd.Parameters["@retValue"].Value;
                }

                con.Close();

            }
            return (valorVerificacion == 1);
        }
    }
}
