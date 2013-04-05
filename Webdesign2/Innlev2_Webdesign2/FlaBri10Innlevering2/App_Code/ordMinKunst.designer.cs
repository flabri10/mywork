﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BildeDatabase")]
public partial class ormMinKunstDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertBilde(Bilde instance);
  partial void UpdateBilde(Bilde instance);
  partial void DeleteBilde(Bilde instance);
  partial void InsertKommentar(Kommentar instance);
  partial void UpdateKommentar(Kommentar instance);
  partial void DeleteKommentar(Kommentar instance);
  partial void InsertBruker(Bruker instance);
  partial void UpdateBruker(Bruker instance);
  partial void DeleteBruker(Bruker instance);
  #endregion
	
	public ormMinKunstDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BildeDatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public ormMinKunstDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ormMinKunstDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ormMinKunstDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ormMinKunstDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Bilde> Bildes
	{
		get
		{
			return this.GetTable<Bilde>();
		}
	}
	
	public System.Data.Linq.Table<Kommentar> Kommentars
	{
		get
		{
			return this.GetTable<Kommentar>();
		}
	}
	
	public System.Data.Linq.Table<Bruker> Brukers
	{
		get
		{
			return this.GetTable<Bruker>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bilde")]
public partial class Bilde : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _BildeId;
	
	private string _Tittel;
	
	private string _Bildenavn;
	
	private int _BrukerId;
	
	private System.Nullable<int> _KommentarId;
	
	private EntitySet<Kommentar> _Kommentars;
	
	private EntityRef<Kommentar> _Kommentar;
	
	private EntityRef<Bruker> _Bruker;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBildeIdChanging(string value);
    partial void OnBildeIdChanged();
    partial void OnTittelChanging(string value);
    partial void OnTittelChanged();
    partial void OnBildenavnChanging(string value);
    partial void OnBildenavnChanged();
    partial void OnBrukerIdChanging(int value);
    partial void OnBrukerIdChanged();
    partial void OnKommentarIdChanging(System.Nullable<int> value);
    partial void OnKommentarIdChanged();
    #endregion
	
	public Bilde()
	{
		this._Kommentars = new EntitySet<Kommentar>(new Action<Kommentar>(this.attach_Kommentars), new Action<Kommentar>(this.detach_Kommentars));
		this._Kommentar = default(EntityRef<Kommentar>);
		this._Bruker = default(EntityRef<Bruker>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BildeId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string BildeId
	{
		get
		{
			return this._BildeId;
		}
		set
		{
			if ((this._BildeId != value))
			{
				this.OnBildeIdChanging(value);
				this.SendPropertyChanging();
				this._BildeId = value;
				this.SendPropertyChanged("BildeId");
				this.OnBildeIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tittel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Tittel
	{
		get
		{
			return this._Tittel;
		}
		set
		{
			if ((this._Tittel != value))
			{
				this.OnTittelChanging(value);
				this.SendPropertyChanging();
				this._Tittel = value;
				this.SendPropertyChanged("Tittel");
				this.OnTittelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bildenavn", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Bildenavn
	{
		get
		{
			return this._Bildenavn;
		}
		set
		{
			if ((this._Bildenavn != value))
			{
				this.OnBildenavnChanging(value);
				this.SendPropertyChanging();
				this._Bildenavn = value;
				this.SendPropertyChanged("Bildenavn");
				this.OnBildenavnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrukerId", DbType="Int NOT NULL")]
	public int BrukerId
	{
		get
		{
			return this._BrukerId;
		}
		set
		{
			if ((this._BrukerId != value))
			{
				if (this._Bruker.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnBrukerIdChanging(value);
				this.SendPropertyChanging();
				this._BrukerId = value;
				this.SendPropertyChanged("BrukerId");
				this.OnBrukerIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KommentarId", DbType="Int")]
	public System.Nullable<int> KommentarId
	{
		get
		{
			return this._KommentarId;
		}
		set
		{
			if ((this._KommentarId != value))
			{
				if (this._Kommentar.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnKommentarIdChanging(value);
				this.SendPropertyChanging();
				this._KommentarId = value;
				this.SendPropertyChanged("KommentarId");
				this.OnKommentarIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bilde_Kommentar", Storage="_Kommentars", ThisKey="BildeId", OtherKey="BildeId")]
	public EntitySet<Kommentar> Kommentars
	{
		get
		{
			return this._Kommentars;
		}
		set
		{
			this._Kommentars.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kommentar_Bilde", Storage="_Kommentar", ThisKey="KommentarId", OtherKey="KommentarId", IsForeignKey=true)]
	public Kommentar Kommentar
	{
		get
		{
			return this._Kommentar.Entity;
		}
		set
		{
			Kommentar previousValue = this._Kommentar.Entity;
			if (((previousValue != value) 
						|| (this._Kommentar.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Kommentar.Entity = null;
					previousValue.Bildes.Remove(this);
				}
				this._Kommentar.Entity = value;
				if ((value != null))
				{
					value.Bildes.Add(this);
					this._KommentarId = value.KommentarId;
				}
				else
				{
					this._KommentarId = default(Nullable<int>);
				}
				this.SendPropertyChanged("Kommentar");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bruker_Bilde", Storage="_Bruker", ThisKey="BrukerId", OtherKey="BrukerId", IsForeignKey=true)]
	public Bruker Bruker
	{
		get
		{
			return this._Bruker.Entity;
		}
		set
		{
			Bruker previousValue = this._Bruker.Entity;
			if (((previousValue != value) 
						|| (this._Bruker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Bruker.Entity = null;
					previousValue.Bildes.Remove(this);
				}
				this._Bruker.Entity = value;
				if ((value != null))
				{
					value.Bildes.Add(this);
					this._BrukerId = value.BrukerId;
				}
				else
				{
					this._BrukerId = default(int);
				}
				this.SendPropertyChanged("Bruker");
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
	
	private void attach_Kommentars(Kommentar entity)
	{
		this.SendPropertyChanging();
		entity.Bilde = this;
	}
	
	private void detach_Kommentars(Kommentar entity)
	{
		this.SendPropertyChanging();
		entity.Bilde = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kommentar")]
public partial class Kommentar : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _KommentarId;
	
	private string _Tittel;
	
	private string _Innhold;
	
	private int _BrukerId;
	
	private string _BildeId;
	
	private EntitySet<Bilde> _Bildes;
	
	private EntityRef<Bilde> _Bilde;
	
	private EntityRef<Bruker> _Bruker;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKommentarIdChanging(int value);
    partial void OnKommentarIdChanged();
    partial void OnTittelChanging(string value);
    partial void OnTittelChanged();
    partial void OnInnholdChanging(string value);
    partial void OnInnholdChanged();
    partial void OnBrukerIdChanging(int value);
    partial void OnBrukerIdChanged();
    partial void OnBildeIdChanging(string value);
    partial void OnBildeIdChanged();
    #endregion
	
	public Kommentar()
	{
		this._Bildes = new EntitySet<Bilde>(new Action<Bilde>(this.attach_Bildes), new Action<Bilde>(this.detach_Bildes));
		this._Bilde = default(EntityRef<Bilde>);
		this._Bruker = default(EntityRef<Bruker>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KommentarId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int KommentarId
	{
		get
		{
			return this._KommentarId;
		}
		set
		{
			if ((this._KommentarId != value))
			{
				this.OnKommentarIdChanging(value);
				this.SendPropertyChanging();
				this._KommentarId = value;
				this.SendPropertyChanged("KommentarId");
				this.OnKommentarIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tittel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Tittel
	{
		get
		{
			return this._Tittel;
		}
		set
		{
			if ((this._Tittel != value))
			{
				this.OnTittelChanging(value);
				this.SendPropertyChanging();
				this._Tittel = value;
				this.SendPropertyChanged("Tittel");
				this.OnTittelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Innhold", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
	public string Innhold
	{
		get
		{
			return this._Innhold;
		}
		set
		{
			if ((this._Innhold != value))
			{
				this.OnInnholdChanging(value);
				this.SendPropertyChanging();
				this._Innhold = value;
				this.SendPropertyChanged("Innhold");
				this.OnInnholdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrukerId", DbType="Int NOT NULL")]
	public int BrukerId
	{
		get
		{
			return this._BrukerId;
		}
		set
		{
			if ((this._BrukerId != value))
			{
				if (this._Bruker.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnBrukerIdChanging(value);
				this.SendPropertyChanging();
				this._BrukerId = value;
				this.SendPropertyChanged("BrukerId");
				this.OnBrukerIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BildeId", DbType="NVarChar(50)")]
	public string BildeId
	{
		get
		{
			return this._BildeId;
		}
		set
		{
			if ((this._BildeId != value))
			{
				if (this._Bilde.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnBildeIdChanging(value);
				this.SendPropertyChanging();
				this._BildeId = value;
				this.SendPropertyChanged("BildeId");
				this.OnBildeIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kommentar_Bilde", Storage="_Bildes", ThisKey="KommentarId", OtherKey="KommentarId")]
	public EntitySet<Bilde> Bildes
	{
		get
		{
			return this._Bildes;
		}
		set
		{
			this._Bildes.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bilde_Kommentar", Storage="_Bilde", ThisKey="BildeId", OtherKey="BildeId", IsForeignKey=true)]
	public Bilde Bilde
	{
		get
		{
			return this._Bilde.Entity;
		}
		set
		{
			Bilde previousValue = this._Bilde.Entity;
			if (((previousValue != value) 
						|| (this._Bilde.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Bilde.Entity = null;
					previousValue.Kommentars.Remove(this);
				}
				this._Bilde.Entity = value;
				if ((value != null))
				{
					value.Kommentars.Add(this);
					this._BildeId = value.BildeId;
				}
				else
				{
					this._BildeId = default(string);
				}
				this.SendPropertyChanged("Bilde");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bruker_Kommentar", Storage="_Bruker", ThisKey="BrukerId", OtherKey="BrukerId", IsForeignKey=true)]
	public Bruker Bruker
	{
		get
		{
			return this._Bruker.Entity;
		}
		set
		{
			Bruker previousValue = this._Bruker.Entity;
			if (((previousValue != value) 
						|| (this._Bruker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Bruker.Entity = null;
					previousValue.Kommentars.Remove(this);
				}
				this._Bruker.Entity = value;
				if ((value != null))
				{
					value.Kommentars.Add(this);
					this._BrukerId = value.BrukerId;
				}
				else
				{
					this._BrukerId = default(int);
				}
				this.SendPropertyChanged("Bruker");
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
	
	private void attach_Bildes(Bilde entity)
	{
		this.SendPropertyChanging();
		entity.Kommentar = this;
	}
	
	private void detach_Bildes(Bilde entity)
	{
		this.SendPropertyChanging();
		entity.Kommentar = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bruker")]
public partial class Bruker : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _BrukerId;
	
	private string _Brukernavn;
	
	private string _Passord;
	
	private string _Navn;
	
	private string _Profilbilde;
	
	private EntitySet<Bilde> _Bildes;
	
	private EntitySet<Kommentar> _Kommentars;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBrukerIdChanging(int value);
    partial void OnBrukerIdChanged();
    partial void OnBrukernavnChanging(string value);
    partial void OnBrukernavnChanged();
    partial void OnPassordChanging(string value);
    partial void OnPassordChanged();
    partial void OnNavnChanging(string value);
    partial void OnNavnChanged();
    partial void OnProfilbildeChanging(string value);
    partial void OnProfilbildeChanged();
    #endregion
	
	public Bruker()
	{
		this._Bildes = new EntitySet<Bilde>(new Action<Bilde>(this.attach_Bildes), new Action<Bilde>(this.detach_Bildes));
		this._Kommentars = new EntitySet<Kommentar>(new Action<Kommentar>(this.attach_Kommentars), new Action<Kommentar>(this.detach_Kommentars));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrukerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int BrukerId
	{
		get
		{
			return this._BrukerId;
		}
		set
		{
			if ((this._BrukerId != value))
			{
				this.OnBrukerIdChanging(value);
				this.SendPropertyChanging();
				this._BrukerId = value;
				this.SendPropertyChanged("BrukerId");
				this.OnBrukerIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brukernavn", DbType="NChar(50)")]
	public string Brukernavn
	{
		get
		{
			return this._Brukernavn;
		}
		set
		{
			if ((this._Brukernavn != value))
			{
				this.OnBrukernavnChanging(value);
				this.SendPropertyChanging();
				this._Brukernavn = value;
				this.SendPropertyChanged("Brukernavn");
				this.OnBrukernavnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passord", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
	public string Passord
	{
		get
		{
			return this._Passord;
		}
		set
		{
			if ((this._Passord != value))
			{
				this.OnPassordChanging(value);
				this.SendPropertyChanging();
				this._Passord = value;
				this.SendPropertyChanged("Passord");
				this.OnPassordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Navn", DbType="NVarChar(50)")]
	public string Navn
	{
		get
		{
			return this._Navn;
		}
		set
		{
			if ((this._Navn != value))
			{
				this.OnNavnChanging(value);
				this.SendPropertyChanging();
				this._Navn = value;
				this.SendPropertyChanged("Navn");
				this.OnNavnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profilbilde", DbType="NVarChar(30)")]
	public string Profilbilde
	{
		get
		{
			return this._Profilbilde;
		}
		set
		{
			if ((this._Profilbilde != value))
			{
				this.OnProfilbildeChanging(value);
				this.SendPropertyChanging();
				this._Profilbilde = value;
				this.SendPropertyChanged("Profilbilde");
				this.OnProfilbildeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bruker_Bilde", Storage="_Bildes", ThisKey="BrukerId", OtherKey="BrukerId")]
	public EntitySet<Bilde> Bildes
	{
		get
		{
			return this._Bildes;
		}
		set
		{
			this._Bildes.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bruker_Kommentar", Storage="_Kommentars", ThisKey="BrukerId", OtherKey="BrukerId")]
	public EntitySet<Kommentar> Kommentars
	{
		get
		{
			return this._Kommentars;
		}
		set
		{
			this._Kommentars.Assign(value);
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
	
	private void attach_Bildes(Bilde entity)
	{
		this.SendPropertyChanging();
		entity.Bruker = this;
	}
	
	private void detach_Bildes(Bilde entity)
	{
		this.SendPropertyChanging();
		entity.Bruker = null;
	}
	
	private void attach_Kommentars(Kommentar entity)
	{
		this.SendPropertyChanging();
		entity.Bruker = this;
	}
	
	private void detach_Kommentars(Kommentar entity)
	{
		this.SendPropertyChanging();
		entity.Bruker = null;
	}
}
#pragma warning restore 1591