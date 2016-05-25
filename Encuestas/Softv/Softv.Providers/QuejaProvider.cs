﻿
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.Remoting;
using Softv.Entities;
using SoftvConfiguration;
using Globals;

namespace Softv.Providers
{
    /// <summary>
    /// Class                   : Softv.Providers.QuejaProvider
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Queja Provider
    /// File                    : QuejaProvider.cs
    /// Creation date           : 20/05/2016
    /// Creation time           : 06:37 p. m.
    /// </summary>
    public abstract class QuejaProvider : Globals.DataAccess
    {

        /// <summary>
        /// Instance of Queja from DB
        /// </summary>
        private static QuejaProvider _Instance = null;

        private static ObjectHandle obj;
        /// <summary>
        /// Generates a Queja instance
        /// </summary>
        public static QuejaProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    obj = Activator.CreateInstance(
                    SoftvSettings.Settings.Queja.Assembly,
                    SoftvSettings.Settings.Queja.DataClass);
                    _Instance = (QuejaProvider)obj.Unwrap();
                }
                return _Instance;
            }
        }

        /// <summary>
        /// Provider's default constructor
        /// </summary>
        public QuejaProvider()
        {
        }
        /// <summary>
        /// Abstract method to add Queja
        ///  /summary>
        /// <param name="Queja"></param>
        /// <returns></returns>
        public abstract int AddQueja(QuejaEntity entity_Queja);

        /// <summary>
        /// Abstract method to delete Queja
        /// </summary>
        public abstract int DeleteQueja(long? Clv_Queja);

        /// <summary>
        /// Abstract method to update Queja
        /// </summary>
        public abstract int EditQueja(QuejaEntity entity_Queja);

        /// <summary>
        /// Abstract method to get all Queja
        /// </summary>
        public abstract List<QuejaEntity> GetQueja();

        /// <summary>
        /// Abstract method to get all Queja List<int> lid
        /// </summary>
        public abstract List<QuejaEntity> GetQueja(List<long> lid);

        /// <summary>
        /// Abstract method to get by id
        /// </summary>
        public abstract QuejaEntity GetQuejaById(long? Clv_Queja);


        public abstract List<QuejaEntity> GetQuejaByClv_Queja(long? Clv_Queja);


        /// <summary>
        ///Get Queja
        ///</summary>
        public abstract SoftvList<QuejaEntity> GetPagedList(int pageIndex, int pageSize);

        /// <summary>
        ///Get Queja
        ///</summary>
        public abstract SoftvList<QuejaEntity> GetPagedList(int pageIndex, int pageSize, String xml);

        /// <summary>
        /// Converts data from reader to entity
        /// </summary>
        protected virtual QuejaEntity GetQuejaFromReader(IDataReader reader)
        {
            QuejaEntity entity_Queja = null;
            try
            {
                entity_Queja = new QuejaEntity();
                entity_Queja.Clv_Queja = (long?)(GetFromReader(reader, "Clv_Queja"));
                entity_Queja.Clv_TipSer = (int?)(GetFromReader(reader, "Clv_TipSer"));
                entity_Queja.Contrato = (long?)(GetFromReader(reader, "Contrato"));
                entity_Queja.Fecha_Soliciutud = (DateTime?)(GetFromReader(reader, "Fecha_Soliciutud"));
                entity_Queja.Fecha_Ejecucion = (DateTime?)(GetFromReader(reader, "Fecha_Ejecucion"));
                entity_Queja.Observaciones = (String)(GetFromReader(reader, "Observaciones", IsString: true));
                entity_Queja.Status = (String)(GetFromReader(reader, "Status", IsString: true));
                entity_Queja.Clave_Tecnico = (int?)(GetFromReader(reader, "Clave_Tecnico"));
                entity_Queja.Problema = (String)(GetFromReader(reader, "Problema", IsString: true));
                entity_Queja.Solucion = (String)(GetFromReader(reader, "Solucion", IsString: true));
                entity_Queja.Fecha_Actualizacion = (DateTime?)(GetFromReader(reader, "Fecha_Actualizacion"));
                entity_Queja.Fecha_Captura = (DateTime?)(GetFromReader(reader, "Fecha_Captura"));
                entity_Queja.Clv_TipoQueja = (String)(GetFromReader(reader, "Clv_TipoQueja", IsString: true));
                entity_Queja.Imp = (String)(GetFromReader(reader, "Imp", IsString: true));
                entity_Queja.Clasificacion = (String)(GetFromReader(reader, "Clasificacion", IsString: true));
                entity_Queja.Hora_Ejecucion = (DateTime?)(GetFromReader(reader, "Hora_Ejecucion"));
                entity_Queja.Clv_Trabajo = (int?)(GetFromReader(reader, "Clv_Trabajo"));
                entity_Queja.Impresa = (bool?)(GetFromReader(reader, "Impresa"));
                entity_Queja.Visita1 = (DateTime?)(GetFromReader(reader, "Visita1"));
                entity_Queja.Visita2 = (DateTime?)(GetFromReader(reader, "Visita2"));
                entity_Queja.Visita3 = (DateTime?)(GetFromReader(reader, "Visita3"));
                entity_Queja.clvPrioridadQueja = (int?)(GetFromReader(reader, "clvPrioridadQueja"));

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting Queja data to entity", ex);
            }
            return entity_Queja;
        }

    }

    #region Customs Methods

    #endregion
}

