﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Engineer")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertEng_info(Eng_info instance);
    partial void UpdateEng_info(Eng_info instance);
    partial void DeleteEng_info(Eng_info instance);
    partial void InsertEng_info1(Eng_info1 instance);
    partial void UpdateEng_info1(Eng_info1 instance);
    partial void DeleteEng_info1(Eng_info1 instance);
    partial void InsertLog_info(Log_info instance);
    partial void UpdateLog_info(Log_info instance);
    partial void DeleteLog_info(Log_info instance);
    partial void Insertt_user(t_user instance);
    partial void Updatet_user(t_user instance);
    partial void Deletet_user(t_user instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EngineerConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Eng_info> Eng_info
		{
			get
			{
				return this.GetTable<Eng_info>();
			}
		}
		
		public System.Data.Linq.Table<Eng_info1> Eng_info1
		{
			get
			{
				return this.GetTable<Eng_info1>();
			}
		}
		
		public System.Data.Linq.Table<Log_info> Log_info
		{
			get
			{
				return this.GetTable<Log_info>();
			}
		}
		
		public System.Data.Linq.Table<t_user> t_user
		{
			get
			{
				return this.GetTable<t_user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Eng_info")]
	public partial class Eng_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _no;
		
		private string _sex;
		
		private string _address;
		
		private string _telephone;
		
		private System.Nullable<int> _working_age;
		
		private string _basic_salary;
		
		private System.Nullable<System.DateTime> _birthday;
		
		private string _education;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnoChanging(string value);
    partial void OnnoChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void Onworking_ageChanging(System.Nullable<int> value);
    partial void Onworking_ageChanged();
    partial void Onbasic_salaryChanging(string value);
    partial void Onbasic_salaryChanged();
    partial void OnbirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthdayChanged();
    partial void OneducationChanging(string value);
    partial void OneducationChanged();
    #endregion
		
		public Eng_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(8) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no", DbType="NChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string no
		{
			get
			{
				return this._no;
			}
			set
			{
				if ((this._no != value))
				{
					this.OnnoChanging(value);
					this.SendPropertyChanging();
					this._no = value;
					this.SendPropertyChanged("no");
					this.OnnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="NChar(2)")]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NChar(30)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="NChar(13)")]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_working_age", DbType="Int")]
		public System.Nullable<int> working_age
		{
			get
			{
				return this._working_age;
			}
			set
			{
				if ((this._working_age != value))
				{
					this.Onworking_ageChanging(value);
					this.SendPropertyChanging();
					this._working_age = value;
					this.SendPropertyChanged("working_age");
					this.Onworking_ageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_basic_salary", DbType="NChar(20)")]
		public string basic_salary
		{
			get
			{
				return this._basic_salary;
			}
			set
			{
				if ((this._basic_salary != value))
				{
					this.Onbasic_salaryChanging(value);
					this.SendPropertyChanging();
					this._basic_salary = value;
					this.SendPropertyChanged("basic_salary");
					this.Onbasic_salaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this.OnbirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("birthday");
					this.OnbirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_education", DbType="NChar(30)")]
		public string education
		{
			get
			{
				return this._education;
			}
			set
			{
				if ((this._education != value))
				{
					this.OneducationChanging(value);
					this.SendPropertyChanging();
					this._education = value;
					this.SendPropertyChanged("education");
					this.OneducationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Eng_info")]
	public partial class Eng_info1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _no;
		
		private string _sex;
		
		private string _address;
		
		private string _telephone;
		
		private System.Nullable<int> _working_age;
		
		private string _basic_salary;
		
		private System.Nullable<System.DateTime> _birthday;
		
		private string _education;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnoChanging(string value);
    partial void OnnoChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void Onworking_ageChanging(System.Nullable<int> value);
    partial void Onworking_ageChanged();
    partial void Onbasic_salaryChanging(string value);
    partial void Onbasic_salaryChanged();
    partial void OnbirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthdayChanged();
    partial void OneducationChanging(string value);
    partial void OneducationChanged();
    #endregion
		
		public Eng_info1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(8) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no", DbType="NChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string no
		{
			get
			{
				return this._no;
			}
			set
			{
				if ((this._no != value))
				{
					this.OnnoChanging(value);
					this.SendPropertyChanging();
					this._no = value;
					this.SendPropertyChanged("no");
					this.OnnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="NChar(2)")]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NChar(30)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="NChar(13)")]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_working_age", DbType="Int")]
		public System.Nullable<int> working_age
		{
			get
			{
				return this._working_age;
			}
			set
			{
				if ((this._working_age != value))
				{
					this.Onworking_ageChanging(value);
					this.SendPropertyChanging();
					this._working_age = value;
					this.SendPropertyChanged("working_age");
					this.Onworking_ageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_basic_salary", DbType="NChar(20)")]
		public string basic_salary
		{
			get
			{
				return this._basic_salary;
			}
			set
			{
				if ((this._basic_salary != value))
				{
					this.Onbasic_salaryChanging(value);
					this.SendPropertyChanging();
					this._basic_salary = value;
					this.SendPropertyChanged("basic_salary");
					this.Onbasic_salaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this.OnbirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("birthday");
					this.OnbirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_education", DbType="NChar(30)")]
		public string education
		{
			get
			{
				return this._education;
			}
			set
			{
				if ((this._education != value))
				{
					this.OneducationChanging(value);
					this.SendPropertyChanging();
					this._education = value;
					this.SendPropertyChanged("education");
					this.OneducationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Log_info")]
	public partial class Log_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _operate;
		
		private string _change;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnoperateChanging(string value);
    partial void OnoperateChanged();
    partial void OnchangeChanging(string value);
    partial void OnchangeChanged();
    #endregion
		
		public Log_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_operate", DbType="NChar(10)")]
		public string operate
		{
			get
			{
				return this._operate;
			}
			set
			{
				if ((this._operate != value))
				{
					this.OnoperateChanging(value);
					this.SendPropertyChanging();
					this._operate = value;
					this.SendPropertyChanged("operate");
					this.OnoperateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_change", DbType="NChar(100)")]
		public string change
		{
			get
			{
				return this._change;
			}
			set
			{
				if ((this._change != value))
				{
					this.OnchangeChanging(value);
					this.SendPropertyChanging();
					this._change = value;
					this.SendPropertyChanged("change");
					this.OnchangeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_user")]
	public partial class t_user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _account;
		
		private string _password;
		
		private int _category;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnaccountChanging(string value);
    partial void OnaccountChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OncategoryChanging(int value);
    partial void OncategoryChanged();
    #endregion
		
		public t_user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string account
		{
			get
			{
				return this._account;
			}
			set
			{
				if ((this._account != value))
				{
					this.OnaccountChanging(value);
					this.SendPropertyChanging();
					this._account = value;
					this.SendPropertyChanged("account");
					this.OnaccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="Int NOT NULL")]
		public int category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
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