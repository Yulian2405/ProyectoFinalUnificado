﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Seguridad
{
    public abstract class UserConnectionToSql
    {
        private readonly string connectionString;
        public UserConnectionToSql()
        {
            connectionString = "Data Source=YULIAN\\SQLEXPRESS;Initial Catalog=db_MenuLogin;Integrated Security=True;Encrypt=False";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
