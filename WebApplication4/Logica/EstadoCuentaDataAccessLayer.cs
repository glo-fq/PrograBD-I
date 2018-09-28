using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class EstadoCuentaDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        //Retorna los estados de cuenta de un id de cuenta dado
        public IEnumerable<EstadoCuenta> GetEstadosCuenta(int idCuenta) {
            List<EstadoCuenta> listaEstadosCuenta = new List<EstadoCuenta>();
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("GetEstadosCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigoCuenta", idCuenta);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()){
                    //En el stored procedure hace falta pedir el Id
                    EstadoCuenta estadoCuenta = new EstadoCuenta(Convert.ToInt32(rdr["idCuenta"]), Convert.ToDateTime(rdr["fechaCorte"]), Convert.ToDecimal(rdr["saldoInicial"]), Convert.ToDecimal(rdr["saldoFinal"]), Convert.ToInt32(rdr["cantOpManual"]), Convert.ToInt32(rdr["cantOpATM"]), Convert.ToDecimal(rdr["saldoMin"]));

                    listaEstadosCuenta.Add(estadoCuenta);
                }
                con.Close();
            }
            return listaEstadosCuenta;
        }
    }
}
