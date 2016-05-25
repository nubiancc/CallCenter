﻿
using System;
using System.Configuration;

namespace SoftvConfiguration
{
    public class Cliente_ApellidoElement : ConfigurationElement
    {
        /// <summary>
        /// Gets assembly name for Cliente_Apellido class
        /// </summary>
        [ConfigurationProperty("Assembly")]
        public String Assembly
        {
            get
            {
                string assembly = (string)base["Assembly"];
                assembly = String.IsNullOrEmpty(assembly) ?
                SoftvSettings.Settings.Assembly :
                (string)base["Assembly"];
                return assembly;
            }
        }

        /// <summary>
        /// Gets class name for Cliente_Apellido
        ///</summary>
        [ConfigurationProperty("DataClassCliente_Apellido", DefaultValue = "Softv.DAO.Cliente_ApellidoData")]
        public String DataClass
        {
            get { return (string)base["DataClassCliente_Apellido"]; }
        }

        /// <summary>
        /// Gets connection string for database Cliente_Apellido access
        ///</summary>
        [ConfigurationProperty("ConnectionString")]
        public String ConnectionString
        {
            get
            {
                string connectionString = (string)base["ConnectionString"];
                connectionString = String.IsNullOrEmpty(connectionString) ? SoftvSettings.Settings.ConnectionString : (string)base["ConnectionString"];
                return connectionString;
            }
        }
    }
}

