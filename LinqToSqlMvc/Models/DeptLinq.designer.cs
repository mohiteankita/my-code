﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLinkToSql.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HRMSDB")]
	public partial class DeptLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDEPARTMENT(DEPARTMENT instance);
    partial void UpdateDEPARTMENT(DEPARTMENT instance);
    partial void DeleteDEPARTMENT(DEPARTMENT instance);
    #endregion
		
		public DeptLinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HRMSDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DeptLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeptLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeptLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeptLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DEPARTMENT> DEPARTMENTs
		{
			get
			{
				return this.GetTable<DEPARTMENT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPARTMENTS")]
	public partial class DEPARTMENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _DEPARTMENT_ID;
		
		private string _DEPARTMENT_NAME;
		
		private System.Nullable<decimal> _MANAGER_ID;
		
		private System.Nullable<decimal> _LOCATION_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDEPARTMENT_IDChanging(decimal value);
    partial void OnDEPARTMENT_IDChanged();
    partial void OnDEPARTMENT_NAMEChanging(string value);
    partial void OnDEPARTMENT_NAMEChanged();
    partial void OnMANAGER_IDChanging(System.Nullable<decimal> value);
    partial void OnMANAGER_IDChanged();
    partial void OnLOCATION_IDChanging(System.Nullable<decimal> value);
    partial void OnLOCATION_IDChanged();
    #endregion
		
		public DEPARTMENT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPARTMENT_ID", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal DEPARTMENT_ID
		{
			get
			{
				return this._DEPARTMENT_ID;
			}
			set
			{
				if ((this._DEPARTMENT_ID != value))
				{
					this.OnDEPARTMENT_IDChanging(value);
					this.SendPropertyChanging();
					this._DEPARTMENT_ID = value;
					this.SendPropertyChanged("DEPARTMENT_ID");
					this.OnDEPARTMENT_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPARTMENT_NAME", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string DEPARTMENT_NAME
		{
			get
			{
				return this._DEPARTMENT_NAME;
			}
			set
			{
				if ((this._DEPARTMENT_NAME != value))
				{
					this.OnDEPARTMENT_NAMEChanging(value);
					this.SendPropertyChanging();
					this._DEPARTMENT_NAME = value;
					this.SendPropertyChanged("DEPARTMENT_NAME");
					this.OnDEPARTMENT_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANAGER_ID", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> MANAGER_ID
		{
			get
			{
				return this._MANAGER_ID;
			}
			set
			{
				if ((this._MANAGER_ID != value))
				{
					this.OnMANAGER_IDChanging(value);
					this.SendPropertyChanging();
					this._MANAGER_ID = value;
					this.SendPropertyChanged("MANAGER_ID");
					this.OnMANAGER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCATION_ID", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> LOCATION_ID
		{
			get
			{
				return this._LOCATION_ID;
			}
			set
			{
				if ((this._LOCATION_ID != value))
				{
					this.OnLOCATION_IDChanging(value);
					this.SendPropertyChanging();
					this._LOCATION_ID = value;
					this.SendPropertyChanged("LOCATION_ID");
					this.OnLOCATION_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
