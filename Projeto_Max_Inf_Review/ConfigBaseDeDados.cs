using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Projeto_Max_Inf_Review
{
    class ConfigBaseDeDados
    {
        private readonly FormDbConfig formDbconfig;
        private static ConfigBaseDeDados ;

        public string InstanciaSQL;
        public string NomeBD;
        public string Utilizador;
        public string Password;
        private SqlConnection sqlConnection;

        


        
        public static ConfigBaseDeDados Config
        {
            get
            { 

                if(config == null)
                {
                    config = new ConfigBaseDeDados();
                }
                return config;
             }
        }

        private ConfigBaseDeDados()
        {
            formDbconfig = new FormDbConfig();
        }

        public void TestConexao()
        {
            try
            {
                LoadConfig();
                var conexao = GetConnectionString();
                sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO no carregamento do Banco de Dados!" + e.Message);
 
                
            }
        }
        
        internal void Configurar()
        {
            if(formDbconfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TestConexao();
            }
        }
