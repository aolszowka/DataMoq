﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataMock.DataTests.DataObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataMock")]
	public partial class DataMockDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChild(Child instance);
    partial void UpdateChild(Child instance);
    partial void DeleteChild(Child instance);
    partial void InsertParent(Parent instance);
    partial void UpdateParent(Parent instance);
    partial void DeleteParent(Parent instance);
    #endregion
		
		public DataMockDataContext() : 
				base(global::DataMock.DataTests.Properties.Settings.Default.DataMockConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataMockDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataMockDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataMockDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataMockDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Child> Childs
		{
			get
			{
				return this.GetTable<Child>();
			}
		}
		
		public System.Data.Linq.Table<Parent> Parents
		{
			get
			{
				return this.GetTable<Parent>();
			}
		}
		
		public System.Data.Linq.Table<People> Peoples
		{
			get
			{
				return this.GetTable<People>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NoParametersProcA")]
		public ISingleResult<NoParametersProcAResult> NoParametersProcA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<NoParametersProcAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NoParametersProcB")]
		public ISingleResult<NoParametersProcBResult> NoParametersProcB()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<NoParametersProcBResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VariableOutputProcA")]
		public ISingleResult<VariableOutputProcAResult> VariableOutputProcA([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> count)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), count);
			return ((ISingleResult<VariableOutputProcAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VariableOutputProcB")]
		public ISingleResult<VariableOutputProcBResult> VariableOutputProcB([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> index)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), index);
			return ((ISingleResult<VariableOutputProcBResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DataTypesFunction", IsComposable=true)]
		public IQueryable<DataTypesFunctionResult> DataTypesFunction([global::System.Data.Linq.Mapping.ParameterAttribute(Name="int", DbType="Int")] System.Nullable<int> @int, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="string", DbType="Char(5)")] string @string, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> guid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dateTime)
		{
			return this.CreateMethodCallQuery<DataTypesFunctionResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), @int, @string, guid, dateTime);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ScalarFunction", IsComposable=true)]
		public System.Nullable<int> ScalarFunction([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param2)
		{
			return ((System.Nullable<int>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), param1, param2).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ScalarFunctionBoolean", IsComposable=true)]
		public System.Nullable<bool> ScalarFunctionBoolean([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param1)
		{
			return ((System.Nullable<bool>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), param1).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ScalarFunctionString", IsComposable=true)]
		public string ScalarFunctionString([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param1)
		{
			return ((string)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), param1).ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Child")]
	public partial class Child : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _FavoriteSubject;
		
		private int _Parent;
		
		private EntityRef<Parent> _Parent1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFavoriteSubjectChanging(string value);
    partial void OnFavoriteSubjectChanged();
    partial void OnParentChanging(int value);
    partial void OnParentChanged();
    #endregion
		
		public Child()
		{
			this._Parent1 = default(EntityRef<Parent>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FavoriteSubject", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FavoriteSubject
		{
			get
			{
				return this._FavoriteSubject;
			}
			set
			{
				if ((this._FavoriteSubject != value))
				{
					this.OnFavoriteSubjectChanging(value);
					this.SendPropertyChanging();
					this._FavoriteSubject = value;
					this.SendPropertyChanged("FavoriteSubject");
					this.OnFavoriteSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="Int NOT NULL")]
		public int Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					if (this._Parent1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentChanging(value);
					this.SendPropertyChanging();
					this._Parent = value;
					this.SendPropertyChanged("Parent");
					this.OnParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Parent_Child", Storage="_Parent1", ThisKey="Parent", OtherKey="Id", IsForeignKey=true)]
		public Parent Parent1
		{
			get
			{
				return this._Parent1.Entity;
			}
			set
			{
				Parent previousValue = this._Parent1.Entity;
				if (((previousValue != value) 
							|| (this._Parent1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Parent1.Entity = null;
						previousValue.Childs.Remove(this);
					}
					this._Parent1.Entity = value;
					if ((value != null))
					{
						value.Childs.Add(this);
						this._Parent = value.Id;
					}
					else
					{
						this._Parent = default(int);
					}
					this.SendPropertyChanged("Parent1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Parent")]
	public partial class Parent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Child> _Childs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Parent()
		{
			this._Childs = new EntitySet<Child>(new Action<Child>(this.attach_Childs), new Action<Child>(this.detach_Childs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Parent_Child", Storage="_Childs", ThisKey="Id", OtherKey="Parent")]
		public EntitySet<Child> Childs
		{
			get
			{
				return this._Childs;
			}
			set
			{
				this._Childs.Assign(value);
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
		
		private void attach_Childs(Child entity)
		{
			this.SendPropertyChanging();
			entity.Parent1 = this;
		}
		
		private void detach_Childs(Child entity)
		{
			this.SendPropertyChanging();
			entity.Parent1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.People")]
	public partial class People
	{
		
		private string _Child;
		
		private string _Parent;
		
		public People()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Child", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Child
		{
			get
			{
				return this._Child;
			}
			set
			{
				if ((this._Child != value))
				{
					this._Child = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					this._Parent = value;
				}
			}
		}
	}
	
	public partial class NoParametersProcAResult
	{
		
		private System.Nullable<int> _Id;
		
		private string _TextMessage;
		
		public NoParametersProcAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextMessage", DbType="VarChar(MAX)")]
		public string TextMessage
		{
			get
			{
				return this._TextMessage;
			}
			set
			{
				if ((this._TextMessage != value))
				{
					this._TextMessage = value;
				}
			}
		}
	}
	
	public partial class NoParametersProcBResult
	{
		
		private int _ID;
		
		private string _TextMessage;
		
		public NoParametersProcBResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextMessage", DbType="VarChar(MAX)")]
		public string TextMessage
		{
			get
			{
				return this._TextMessage;
			}
			set
			{
				if ((this._TextMessage != value))
				{
					this._TextMessage = value;
				}
			}
		}
	}
	
	public partial class VariableOutputProcAResult
	{
		
		private System.Nullable<int> _Id;
		
		private string _TextMessage;
		
		public VariableOutputProcAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextMessage", DbType="VarChar(MAX)")]
		public string TextMessage
		{
			get
			{
				return this._TextMessage;
			}
			set
			{
				if ((this._TextMessage != value))
				{
					this._TextMessage = value;
				}
			}
		}
	}
	
	public partial class VariableOutputProcBResult
	{
		
		private System.Nullable<int> _Id;
		
		private string _TextMessage;
		
		public VariableOutputProcBResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextMessage", DbType="VarChar(MAX)")]
		public string TextMessage
		{
			get
			{
				return this._TextMessage;
			}
			set
			{
				if ((this._TextMessage != value))
				{
					this._TextMessage = value;
				}
			}
		}
	}
	
	public partial class DataTypesFunctionResult
	{
		
		private System.Nullable<int> _c1;
		
		private string _c2;
		
		private System.Nullable<System.Guid> _c3;
		
		private System.Nullable<System.DateTime> _c4;
		
		public DataTypesFunctionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c1", DbType="Int")]
		public System.Nullable<int> c1
		{
			get
			{
				return this._c1;
			}
			set
			{
				if ((this._c1 != value))
				{
					this._c1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c2", DbType="Char(5)")]
		public string c2
		{
			get
			{
				return this._c2;
			}
			set
			{
				if ((this._c2 != value))
				{
					this._c2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c3", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> c3
		{
			get
			{
				return this._c3;
			}
			set
			{
				if ((this._c3 != value))
				{
					this._c3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c4", DbType="DateTime")]
		public System.Nullable<System.DateTime> c4
		{
			get
			{
				return this._c4;
			}
			set
			{
				if ((this._c4 != value))
				{
					this._c4 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
