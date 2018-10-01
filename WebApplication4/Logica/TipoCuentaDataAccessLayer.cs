using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class TipoCuentaDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        //Conseguir todos los tipos de cuenta
        public IEnumerable<TipoCuenta> GetAllTiposCuenta() {
            List<TipoCuenta> listaTiposCuenta = new List<TipoCuenta>();
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_GetTiposCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    TipoCuenta tipoCuenta = new TipoCuenta(Convert.ToInt32(rdr["id"]), rdr["nombre"].ToString(), Convert.ToDecimal(rdr["tasaInteresAnual"]), Convert.ToDecimal(rdr["saldoMinimo"]), Convert.ToDecimal(rdr["multaSaldoMin"]), Convert.ToDecimal(rdr["multaSaldoNeg"]), Convert.ToDecimal(rdr["cargoServicioMensual"]), Convert.ToInt32(rdr["cantMaxOpManual"]), Convert.ToInt32(rdr["cantMaxOpATM"]), Convert.ToDecimal(rdr["multaOpManual"]), Convert.ToDecimal(rdr["multaOpATM"]));

                    listaTiposCuenta.Add(tipoCuenta);
                }
                con.Close();
            }
            return listaTiposCuenta;
        }

        //Agregar un tipo de cuenta
        public void AddTipoCuenta(TipoCuenta pTipoCuenta) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_AgregarTipoCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", pTipoCuenta.Id);
                cmd.Parameters.AddWithValue("@nombre", pTipoCuenta.Nombre);
                cmd.Parameters.AddWithValue("@tasaInteresAnual", pTipoCuenta.TasaInteresAnual);
                cmd.Parameters.AddWithValue("@saldoMin", pTipoCuenta.SaldoMinimo);
                cmd.Parameters.AddWithValue("@multaSaldoMin", pTipoCuenta.MultaSaldoMinimo);
                cmd.Parameters.AddWithValue("@multaSaldoNeg", pTipoCuenta.MultaSaldoNegativo);
                cmd.Parameters.AddWithValue("@cargoServicioMensual", pTipoCuenta.CargoPorServicioMensual);
                cmd.Parameters.AddWithValue("@cantMaxOpManual", pTipoCuenta.CantMaxOpManual);
                cmd.Parameters.AddWithValue("@cantMaxOpATM", pTipoCuenta.CantMaxOpATM);
                cmd.Parameters.AddWithValue("@multaOpManual", pTipoCuenta.MultaOpManual);
                cmd.Parameters.AddWithValue("@multaOpATM", pTipoCuenta.MultaOpATM);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Eliminar un tipo de cuenta
        public void EliminarTipoCuenta(TipoCuenta pTipoCuenta) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_EliminarTipoCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idTipoCuenta", pTipoCuenta.Id);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }




    }
}
