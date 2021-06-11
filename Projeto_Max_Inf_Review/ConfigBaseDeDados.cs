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
        private readonly FormDbConfig formDb;

        public string InstanciaSQL;
        public string NomeBD;
        public string Utilizador;
        public string Password;
        private SqlConnection sqlConnection;

        
        private static ConfigBaseDeDados config;

        
        public static ConfigBaseDeDados Config()
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
            formDb = new FormDbConfig();
        }
        

    }
}
