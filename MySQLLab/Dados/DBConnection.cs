﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace MySQLLab.Dados
{
    public class DBConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void Create(int id, string nome, string email, string senha)
        {     
            try
            {
             MySqlConnection mySqlConnection = DBConnection.GetConnection();
             using MySqlConnection conn = mySqlConnection;
             
             conn.Open();
             string query = "INSERT INTO tblusuarios (id, nome, email, senha) VALUES (@id, @nome, @email, @senha)";
             MySqlCommand cmd = new MySqlCommand(query, conn);
             cmd.Parameters.AddWithValue("@id", id);
             cmd.Parameters.AddWithValue("@nome", nome);
             cmd.Parameters.AddWithValue("@email", email);
             cmd.Parameters.AddWithValue(@"senha", senha);

             cmd.ExecuteNonQuery();
                conn.Close();
                
            }
             catch (Exception ex)
            { 

             string Erro =  ex.Message.ToString().Trim();
            }
             finally
            { 

            }
            
            
        }
        //LER
        //public DataTable Read()
        //{
        //    try
        //    {
        //     DataTable dt = new DataTable();
        //     MySqlConnection mySqlConnection = DBConnection.GetConnection();
        //     using MySqlConnection conn = mySqlConnection;
        //    {
        //     conn.Open();
        //     string query = "SELECT * FROM tblusuarios";
        //     MySqlCommand cmd = new MySqlCommand(query, conn);
        //     MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //     adapter.Fill(dt);
        //    }
        //     return dt;
        //    }
        //     catch (Exception ex)
        //    {

        //     string Erro = ex.Message.ToString().Trim();
        //    }
        //     finally
        //    {

        //    }


        //}

        public bool Update(int id, string nome, string email, string senha)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE tblusuarios SET nome = @nome, email = @email, senha = @senha WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    // Verifica quantas linhas foram afetadas
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true se pelo menos uma linha foi atualizada
                }
            }
            catch (Exception ex)
            {
                // Log ou tratamento de erro
                Console.WriteLine("Erro ao atualizar: " + ex.Message);
                return false;
            }
        }

        
        public void Delete(int id)
        {
            try
            {
             MySqlConnection mySqlConnection = DBConnection.GetConnection();
             using MySqlConnection conn = mySqlConnection;
            {
             conn.Open();
             string query = "DELETE FROM tblusuarios WHERE id = @id";
             MySqlCommand cmd = new MySqlCommand(query, conn);
             cmd.Parameters.AddWithValue("@id", id);

             cmd.ExecuteNonQuery();
             conn.Close();
            }
            }
             catch (Exception ex)
            {

             string Erro = ex.Message.ToString().Trim();
            }
            finally
            {
            }


        }
        
        
    }
    
}
    



