﻿
using System;
using System.Configuration;

namespace SoftvConfiguration
{
    public class CVECAROLElement : ConfigurationElement
    {
        /// <summary>
        /// Gets assembly name for CVECAROL class
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
        /// Gets class name for CVECAROL
        ///</summary>
        [ConfigurationProperty("DataClassCVECAROL", DefaultValue = "Softv.DAO.CVECAROLData")]
        public String DataClass
        {
            get { return (string)base["DataClassCVECAROL"]; }
        }

        /// <summary>
        /// Gets connection string for database CVECAROL access
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

