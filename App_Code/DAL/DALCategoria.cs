using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Interface;
using Teste.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Teste.DAL
{
    public class DALCategoria: ICategoria
    {
        private static DALCategoria _current = null;
        public static DALCategoria Current
        {
            get
            {
                if (_current == null)
                    _current = new DALCategoria();


                return _current;
            }
        }

        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString;

        protected  DALCategoria() { }

        public List<EntityCategoria> Listar()
        {
            List<EntityCategoria> listResult = new List<EntityCategoria>();
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "SELECT * FROM categoria ORDER by nm_categoria";

                IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                

                while (reader.Read())
                {
                    listResult.Add(new EntityCategoria()
                            {
                                CdCategoria = Convert.ToInt32(reader["cd_categoria"]),
                                NmCategoria = (reader["nm_categoria"] != DBNull.Value ? reader["nm_categoria"].ToString() : String.Empty),
                                DsCategoria = (reader["ds_categoria"] != DBNull.Value ? reader["ds_categoria"].ToString() : String.Empty)
                            }
                        );
                }

            }

            return listResult;
        }

        public List<EntityCategoria> Listar(int pCdCategoria)
        {
            List<EntityCategoria> listResult = new List<EntityCategoria>();
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "SELECT * FROM categoria WHERE cd_categoria = @cd_categoria";

                cmd.Parameters.Add(new SqlParameter("@cd_categoria", pCdCategoria));

                IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    listResult.Add(new EntityCategoria()
                    {
                        CdCategoria = Convert.ToInt32(reader["cd_categoria"]),
                        NmCategoria = (reader["nm_categoria"] != DBNull.Value ? reader["nm_categoria"].ToString() : String.Empty),
                        DsCategoria = (reader["ds_categoria"] != DBNull.Value ? reader["ds_categoria"].ToString() : String.Empty)
                    }
                        );
                }

            }

            return listResult;
        }

        public void Atualizar(EntityCategoria entity)
        {
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "UPDATE categoria SET nm_categoria = @nm_categoria, ds_categoria = @ds_categoria WHERE cd_categoria = @cd_categoria";

                cmd.Parameters.Add(new SqlParameter("@cd_categoria", entity.CdCategoria));
                cmd.Parameters.Add(new SqlParameter("@nm_categoria", entity.NmCategoria));
                cmd.Parameters.Add(new SqlParameter("@ds_categoria", entity.DsCategoria));

                cmd.ExecuteNonQuery();


            }
        }

        public void Incluir(EntityCategoria entity)
        {
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "INSERT INTO categoria (nm_categoria, ds_categoria) VALUES (@nm_categoria, @ds_categoria)";

                cmd.Parameters.Add(new SqlParameter("@nm_categoria", entity.NmCategoria));
                cmd.Parameters.Add(new SqlParameter("@ds_categoria", entity.DsCategoria));

                cmd.ExecuteNonQuery();
            }
        }
    }
}