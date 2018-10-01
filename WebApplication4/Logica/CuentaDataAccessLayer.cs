using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class CuentaDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        public IEnumerable<Cuenta> GetAllCuentas() {
            List<Cuenta> listaCuentas = new List<Cuenta>();
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_Editar_Cuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Cuenta cuenta = new Cuenta(Convert.ToInt32(rdr["Id"]), Convert.ToInt32(rdr["ClienteId"]), Convert.ToDecimal(rdr["saldo"]), Convert.ToDecimal(rdr["interesesAcumulados"]), Convert.ToDateTime(rdr["fechaCreacion"]), Convert.ToInt32(rdr["idTipoCuenta"]));

                    listaCuentas.Add(cuenta);
                }
                con.Close();
            }
            return listaCuentas;
        }


    }
}
