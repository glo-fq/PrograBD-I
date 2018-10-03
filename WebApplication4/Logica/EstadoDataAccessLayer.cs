using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class EstadoDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        //Get todos los estados
        public IEnumerable<Evento> GetAllEstados() {
            List<Evento> listaEstados = new List<Evento>();
            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_GetEstados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Evento estado = new Evento();

                    listaEstados.Add(estado);
                }
                con.Close();
            }

            return listaEstados;
        }

        //Agregar un estado

        //Editar o borrar un estado ???
    }
}