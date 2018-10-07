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

        public List<Object> GetInfoCliente(int pId) {
            Cuenta cuenta = new Cuenta();
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            List<Object> listaRetorno = new List<object>(); //Lista que va a contener el cliente con su info y la lista de movimientos
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.CommandText = "CASP_Get_Info_Actual_Cliente";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", pId);

                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    con.Close();

                    DataTable tablaCuenta = ds.Tables[0];
                    DataTable tablaMovimientos = ds.Tables[1];

                    cuenta.Saldo = (decimal)tablaCuenta.Rows[0][0];
                    cuenta.InteresesAcumulados = (decimal)tablaCuenta.Rows[0][1];
                    cuenta.FechaCreacion = (DateTime)tablaCuenta.Rows[0][2];

                    foreach (DataRow row in tablaMovimientos.Rows) {
                        Movimiento movimiento = new Movimiento();
                        //movimiento.IdCuenta = (int)row[1];
                        movimiento.IdTipoMovimiento = (int)row[2];
                        //movimiento.IdEstadoCuenta = (int)row[3];
                        movimiento.Fecha = (DateTime)row[4];
                        movimiento.Monto = (decimal)row[5];
                        movimiento.Descripcion = (string)row[6];
                        listaMovimientos.Add(movimiento);
                    }
                }

            }
            listaRetorno.Add(cuenta);
            listaRetorno.Add(listaMovimientos);
            return listaRetorno;
        }

        public IEnumerable<EstadoCuenta> GetEstadosCuentaRecientes(int pId) {
            List<EstadoCuenta> listaEstadosCuenta = new List<EstadoCuenta>();
            using (SqlConnection con = new SqlConnection(connectionString)){
                SqlCommand cmd = new SqlCommand("CASP_GetEstadosCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", pId);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()){
                    EstadoCuenta estadoCuenta = new EstadoCuenta(Convert.ToInt32(rdr["idCuenta"]), Convert.ToDateTime(rdr["fechaCorte"]), Convert.ToDecimal(rdr["saldoInicial"]), Convert.ToDecimal(rdr["saldoFinal"]), Convert.ToInt32(rdr["cantOpManual"]), Convert.ToInt32(rdr["cantOpATM"]), Convert.ToDecimal(rdr["saldoMin"]));
                    listaEstadosCuenta.Add(estadoCuenta);
                }
                con.Close();
            }
            return listaEstadosCuenta;
        }

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
