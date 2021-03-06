﻿
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    namespace Softv.Entities
    {
    /// <summary>
    /// Class                   : Softv.Entities.NoClienteEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : NoCliente entity
    /// File                    : NoClienteEntity.cs
    /// Creation date           : 14/06/2016
    /// Creation time           : 10:34 a. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class NoClienteEntity : BaseEntity
    {
    #region Attributes
    
      /// <summary>
      /// Property Id
      /// </summary>
      [DataMember]
      public int? Id { get; set; }
      /// <summary>
      /// Property IdLlamada
      /// </summary>
      [DataMember]
      public int? IdLlamada { get; set; }
      /// <summary>
      /// Property Nombre
      /// </summary>
      [DataMember]
      public int? IdConexion { get; set; }
      /// <summary>
      /// Property Nombre
      /// </summary>
      [DataMember]
      public String Nombre { get; set; }
      /// <summary>
      /// Property Direccion
      /// </summary>
      [DataMember]
      public String Direccion { get; set; }
      /// <summary>
      /// Property Telefono
      /// </summary>
      [DataMember]
      public String Telefono { get; set; }
      /// <summary>
      /// Property Celular
      /// </summary>
      [DataMember]
      public String Celular { get; set; }
      /// <summary>
      /// Property Email
      /// </summary>
      [DataMember]
      public String Email { get; set; }


      [DataMember]
      public int? MotivoLlamada { get; set; }

    #endregion
    }
    }

  