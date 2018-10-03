using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Logica {
    public class EventoDataAccessLayer {
        string connectionString = "Persist Security Info=False;Integrated Security = SSPI;database=BDProgra;server=LAPTOP-O7727F54\\SQLEXPRESS01";

        public IEnumerable<Evento> GetAllEventos() {
            List<Evento> listaEventos = new List<Evento>();

            using (SqlConnection con = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand("CASP_GetEventos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Evento evento = new Evento(Convert.ToInt32(rdr["id"]), Convert.ToInt32(rdr["idAdmin"]), Convert.ToInt32(rdr["idTipoEventos"]), rdr["postIp"].ToString(), Convert.ToDateTime(rdr["postTime"]), rdr["xmlAntes"].ToString(), rdr["xmlDespues"].ToString(), Convert.ToInt32(rdr["entidadId"]));

                    listaEventos.Add(evento);
                }
                con.Close();
            }
            return listaEventos;
        }
    }
}
