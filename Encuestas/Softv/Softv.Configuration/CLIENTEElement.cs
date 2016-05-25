﻿
using System;
using System.Configuration;

namespace SoftvConfiguration
{
    public class CLIENTEElement : ConfigurationElement
    {
        /// <summary>
        /// Gets assembly name for CLIENTE class
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
        /// Gets class name for CLIENTE
        ///</summary>
        [ConfigurationProperty("DataClassCLIENTE", DefaultValue = "Softv.DAO.CLIENTEData")]
        public String DataClass
        {
            get { return (string)base["DataClassCLIENTE"]; }
        }

        /// <summary>
        /// Gets connection string for database CLIENTE access
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

