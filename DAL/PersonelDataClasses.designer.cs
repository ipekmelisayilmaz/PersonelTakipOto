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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PERSONELTAKIP")]
	public partial class PersonelDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAYLAR(AYLAR instance);
    partial void UpdateAYLAR(AYLAR instance);
    partial void DeleteAYLAR(AYLAR instance);
    partial void InsertDEPARTMAN(DEPARTMAN instance);
    partial void UpdateDEPARTMAN(DEPARTMAN instance);
    partial void DeleteDEPARTMAN(DEPARTMAN instance);
    partial void InsertI(I instance);
    partial void UpdateI(I instance);
    partial void DeleteI(I instance);
    partial void InsertISDURUM(ISDURUM instance);
    partial void UpdateISDURUM(ISDURUM instance);
    partial void DeleteISDURUM(ISDURUM instance);
    partial void InsertIZIN(IZIN instance);
    partial void UpdateIZIN(IZIN instance);
    partial void DeleteIZIN(IZIN instance);
    partial void InsertIZINDURUM(IZINDURUM instance);
    partial void UpdateIZINDURUM(IZINDURUM instance);
    partial void DeleteIZINDURUM(IZINDURUM instance);
    partial void InsertPERSONEL(PERSONEL instance);
    partial void UpdatePERSONEL(PERSONEL instance);
    partial void DeletePERSONEL(PERSONEL instance);
    partial void InsertPOZISYON(POZISYON instance);
    partial void UpdatePOZISYON(POZISYON instance);
    partial void DeletePOZISYON(POZISYON instance);
    partial void InsertMAA(MAA instance);
    partial void UpdateMAA(MAA instance);
    partial void DeleteMAA(MAA instance);
    #endregion
		
		public PersonelDataClassesDataContext() : 
				base(global::DAL.Properties.Settings.Default.PERSONELTAKIPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PersonelDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonelDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonelDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonelDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AYLAR> AYLARs
		{
			get
			{
				return this.GetTable<AYLAR>();
			}
		}
		
		public System.Data.Linq.Table<DEPARTMAN> DEPARTMANs
		{
			get
			{
				return this.GetTable<DEPARTMAN>();
			}
		}
		
		public System.Data.Linq.Table<I> Is
		{
			get
			{
				return this.GetTable<I>();
			}
		}
		
		public System.Data.Linq.Table<ISDURUM> ISDURUMs
		{
			get
			{
				return this.GetTable<ISDURUM>();
			}
		}
		
		public System.Data.Linq.Table<IZIN> IZINs
		{
			get
			{
				return this.GetTable<IZIN>();
			}
		}
		
		public System.Data.Linq.Table<IZINDURUM> IZINDURUMs
		{
			get
			{
				return this.GetTable<IZINDURUM>();
			}
		}
		
		public System.Data.Linq.Table<PERSONEL> PERSONELs
		{
			get
			{
				return this.GetTable<PERSONEL>();
			}
		}
		
		public System.Data.Linq.Table<POZISYON> POZISYONs
		{
			get
			{
				return this.GetTable<POZISYON>();
			}
		}
		
		public System.Data.Linq.Table<MAA> MAAs
		{
			get
			{
				return this.GetTable<MAA>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AYLAR")]
	public partial class AYLAR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Ay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAyChanging(string value);
    partial void OnAyChanged();
    #endregion
		
		public AYLAR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ay", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Ay
		{
			get
			{
				return this._Ay;
			}
			set
			{
				if ((this._Ay != value))
				{
					this.OnAyChanging(value);
					this.SendPropertyChanging();
					this._Ay = value;
					this.SendPropertyChanged("Ay");
					this.OnAyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPARTMAN")]
	public partial class DEPARTMAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DepartmanAd;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDepartmanAdChanging(string value);
    partial void OnDepartmanAdChanged();
    #endregion
		
		public DEPARTMAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmanAd", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DepartmanAd
		{
			get
			{
				return this._DepartmanAd;
			}
			set
			{
				if ((this._DepartmanAd != value))
				{
					this.OnDepartmanAdChanging(value);
					this.SendPropertyChanging();
					this._DepartmanAd = value;
					this.SendPropertyChanged("DepartmanAd");
					this.OnDepartmanAdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[IS]")]
	public partial class I : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _PersonelID;
		
		private string _Baslik;
		
		private string _Icerik;
		
		private System.DateTime _IsBaslamaTarih;
		
		private System.DateTime _IsBitisTarih;
		
		private int _IsDurumID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPersonelIDChanging(int value);
    partial void OnPersonelIDChanged();
    partial void OnBaslikChanging(string value);
    partial void OnBaslikChanged();
    partial void OnIcerikChanging(string value);
    partial void OnIcerikChanged();
    partial void OnIsBaslamaTarihChanging(System.DateTime value);
    partial void OnIsBaslamaTarihChanged();
    partial void OnIsBitisTarihChanging(System.DateTime value);
    partial void OnIsBitisTarihChanged();
    partial void OnIsDurumIDChanging(int value);
    partial void OnIsDurumIDChanged();
    #endregion
		
		public I()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonelID", DbType="Int NOT NULL")]
		public int PersonelID
		{
			get
			{
				return this._PersonelID;
			}
			set
			{
				if ((this._PersonelID != value))
				{
					this.OnPersonelIDChanging(value);
					this.SendPropertyChanging();
					this._PersonelID = value;
					this.SendPropertyChanged("PersonelID");
					this.OnPersonelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Baslik", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Baslik
		{
			get
			{
				return this._Baslik;
			}
			set
			{
				if ((this._Baslik != value))
				{
					this.OnBaslikChanging(value);
					this.SendPropertyChanging();
					this._Baslik = value;
					this.SendPropertyChanged("Baslik");
					this.OnBaslikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Icerik", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Icerik
		{
			get
			{
				return this._Icerik;
			}
			set
			{
				if ((this._Icerik != value))
				{
					this.OnIcerikChanging(value);
					this.SendPropertyChanging();
					this._Icerik = value;
					this.SendPropertyChanged("Icerik");
					this.OnIcerikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsBaslamaTarih", DbType="Date NOT NULL")]
		public System.DateTime IsBaslamaTarih
		{
			get
			{
				return this._IsBaslamaTarih;
			}
			set
			{
				if ((this._IsBaslamaTarih != value))
				{
					this.OnIsBaslamaTarihChanging(value);
					this.SendPropertyChanging();
					this._IsBaslamaTarih = value;
					this.SendPropertyChanged("IsBaslamaTarih");
					this.OnIsBaslamaTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsBitisTarih", DbType="Date NOT NULL")]
		public System.DateTime IsBitisTarih
		{
			get
			{
				return this._IsBitisTarih;
			}
			set
			{
				if ((this._IsBitisTarih != value))
				{
					this.OnIsBitisTarihChanging(value);
					this.SendPropertyChanging();
					this._IsBitisTarih = value;
					this.SendPropertyChanged("IsBitisTarih");
					this.OnIsBitisTarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDurumID", DbType="Int NOT NULL")]
		public int IsDurumID
		{
			get
			{
				return this._IsDurumID;
			}
			set
			{
				if ((this._IsDurumID != value))
				{
					this.OnIsDurumIDChanging(value);
					this.SendPropertyChanging();
					this._IsDurumID = value;
					this.SendPropertyChanged("IsDurumID");
					this.OnIsDurumIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ISDURUM")]
	public partial class ISDURUM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _IsDurumAd;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIsDurumAdChanging(string value);
    partial void OnIsDurumAdChanged();
    #endregion
		
		public ISDURUM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDurumAd", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string IsDurumAd
		{
			get
			{
				return this._IsDurumAd;
			}
			set
			{
				if ((this._IsDurumAd != value))
				{
					this.OnIsDurumAdChanging(value);
					this.SendPropertyChanging();
					this._IsDurumAd = value;
					this.SendPropertyChanged("IsDurumAd");
					this.OnIsDurumAdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IZIN")]
	public partial class IZIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _PersonelID;
		
		private System.DateTime _IzinBaslamaTarihi;
		
		private System.DateTime _IzinBitisTarihi;
		
		private string _Acıklama;
		
		private int _Sure;
		
		private int _IzinDurumID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPersonelIDChanging(int value);
    partial void OnPersonelIDChanged();
    partial void OnIzinBaslamaTarihiChanging(System.DateTime value);
    partial void OnIzinBaslamaTarihiChanged();
    partial void OnIzinBitisTarihiChanging(System.DateTime value);
    partial void OnIzinBitisTarihiChanged();
    partial void OnAcıklamaChanging(string value);
    partial void OnAcıklamaChanged();
    partial void OnSureChanging(int value);
    partial void OnSureChanged();
    partial void OnIzinDurumIDChanging(int value);
    partial void OnIzinDurumIDChanged();
    #endregion
		
		public IZIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonelID", DbType="Int NOT NULL")]
		public int PersonelID
		{
			get
			{
				return this._PersonelID;
			}
			set
			{
				if ((this._PersonelID != value))
				{
					this.OnPersonelIDChanging(value);
					this.SendPropertyChanging();
					this._PersonelID = value;
					this.SendPropertyChanged("PersonelID");
					this.OnPersonelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IzinBaslamaTarihi", DbType="Date NOT NULL")]
		public System.DateTime IzinBaslamaTarihi
		{
			get
			{
				return this._IzinBaslamaTarihi;
			}
			set
			{
				if ((this._IzinBaslamaTarihi != value))
				{
					this.OnIzinBaslamaTarihiChanging(value);
					this.SendPropertyChanging();
					this._IzinBaslamaTarihi = value;
					this.SendPropertyChanged("IzinBaslamaTarihi");
					this.OnIzinBaslamaTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IzinBitisTarihi", DbType="Date NOT NULL")]
		public System.DateTime IzinBitisTarihi
		{
			get
			{
				return this._IzinBitisTarihi;
			}
			set
			{
				if ((this._IzinBitisTarihi != value))
				{
					this.OnIzinBitisTarihiChanging(value);
					this.SendPropertyChanging();
					this._IzinBitisTarihi = value;
					this.SendPropertyChanged("IzinBitisTarihi");
					this.OnIzinBitisTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acıklama", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Acıklama
		{
			get
			{
				return this._Acıklama;
			}
			set
			{
				if ((this._Acıklama != value))
				{
					this.OnAcıklamaChanging(value);
					this.SendPropertyChanging();
					this._Acıklama = value;
					this.SendPropertyChanged("Acıklama");
					this.OnAcıklamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sure", DbType="Int NOT NULL")]
		public int Sure
		{
			get
			{
				return this._Sure;
			}
			set
			{
				if ((this._Sure != value))
				{
					this.OnSureChanging(value);
					this.SendPropertyChanging();
					this._Sure = value;
					this.SendPropertyChanged("Sure");
					this.OnSureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IzinDurumID", DbType="Int NOT NULL")]
		public int IzinDurumID
		{
			get
			{
				return this._IzinDurumID;
			}
			set
			{
				if ((this._IzinDurumID != value))
				{
					this.OnIzinDurumIDChanging(value);
					this.SendPropertyChanging();
					this._IzinDurumID = value;
					this.SendPropertyChanged("IzinDurumID");
					this.OnIzinDurumIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IZINDURUM")]
	public partial class IZINDURUM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _IzinDurumAd;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIzinDurumAdChanging(string value);
    partial void OnIzinDurumAdChanged();
    #endregion
		
		public IZINDURUM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IzinDurumAd", DbType="VarChar(50)")]
		public string IzinDurumAd
		{
			get
			{
				return this._IzinDurumAd;
			}
			set
			{
				if ((this._IzinDurumAd != value))
				{
					this.OnIzinDurumAdChanging(value);
					this.SendPropertyChanging();
					this._IzinDurumAd = value;
					this.SendPropertyChanged("IzinDurumAd");
					this.OnIzinDurumAdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERSONEL")]
	public partial class PERSONEL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _UserNo;
		
		private string _Ad;
		
		private string _Soyad;
		
		private string _Resim;
		
		private int _DepartmanID;
		
		private int _PozisyonID;
		
		private int _Maas;
		
		private System.Nullable<System.DateTime> _DogumGunu;
		
		private string _Adres;
		
		private string _Password;
		
		private bool _isAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserNoChanging(int value);
    partial void OnUserNoChanged();
    partial void OnAdChanging(string value);
    partial void OnAdChanged();
    partial void OnSoyadChanging(string value);
    partial void OnSoyadChanged();
    partial void OnResimChanging(string value);
    partial void OnResimChanged();
    partial void OnDepartmanIDChanging(int value);
    partial void OnDepartmanIDChanged();
    partial void OnPozisyonIDChanging(int value);
    partial void OnPozisyonIDChanged();
    partial void OnMaasChanging(int value);
    partial void OnMaasChanged();
    partial void OnDogumGunuChanging(System.Nullable<System.DateTime> value);
    partial void OnDogumGunuChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnisAdminChanging(bool value);
    partial void OnisAdminChanged();
    #endregion
		
		public PERSONEL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNo", DbType="Int NOT NULL")]
		public int UserNo
		{
			get
			{
				return this._UserNo;
			}
			set
			{
				if ((this._UserNo != value))
				{
					this.OnUserNoChanging(value);
					this.SendPropertyChanging();
					this._UserNo = value;
					this.SendPropertyChanged("UserNo");
					this.OnUserNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ad", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Ad
		{
			get
			{
				return this._Ad;
			}
			set
			{
				if ((this._Ad != value))
				{
					this.OnAdChanging(value);
					this.SendPropertyChanging();
					this._Ad = value;
					this.SendPropertyChanged("Ad");
					this.OnAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyad", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Soyad
		{
			get
			{
				return this._Soyad;
			}
			set
			{
				if ((this._Soyad != value))
				{
					this.OnSoyadChanging(value);
					this.SendPropertyChanging();
					this._Soyad = value;
					this.SendPropertyChanged("Soyad");
					this.OnSoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resim", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Resim
		{
			get
			{
				return this._Resim;
			}
			set
			{
				if ((this._Resim != value))
				{
					this.OnResimChanging(value);
					this.SendPropertyChanging();
					this._Resim = value;
					this.SendPropertyChanged("Resim");
					this.OnResimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmanID", DbType="Int NOT NULL")]
		public int DepartmanID
		{
			get
			{
				return this._DepartmanID;
			}
			set
			{
				if ((this._DepartmanID != value))
				{
					this.OnDepartmanIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmanID = value;
					this.SendPropertyChanged("DepartmanID");
					this.OnDepartmanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PozisyonID", DbType="Int NOT NULL")]
		public int PozisyonID
		{
			get
			{
				return this._PozisyonID;
			}
			set
			{
				if ((this._PozisyonID != value))
				{
					this.OnPozisyonIDChanging(value);
					this.SendPropertyChanging();
					this._PozisyonID = value;
					this.SendPropertyChanged("PozisyonID");
					this.OnPozisyonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maas", DbType="Int NOT NULL")]
		public int Maas
		{
			get
			{
				return this._Maas;
			}
			set
			{
				if ((this._Maas != value))
				{
					this.OnMaasChanging(value);
					this.SendPropertyChanging();
					this._Maas = value;
					this.SendPropertyChanged("Maas");
					this.OnMaasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogumGunu", DbType="Date")]
		public System.Nullable<System.DateTime> DogumGunu
		{
			get
			{
				return this._DogumGunu;
			}
			set
			{
				if ((this._DogumGunu != value))
				{
					this.OnDogumGunuChanging(value);
					this.SendPropertyChanging();
					this._DogumGunu = value;
					this.SendPropertyChanged("DogumGunu");
					this.OnDogumGunuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="VarChar(MAX)")]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit NOT NULL")]
		public bool isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.POZISYON")]
	public partial class POZISYON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PozisyonAd;
		
		private int _DepartmanID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPozisyonAdChanging(string value);
    partial void OnPozisyonAdChanged();
    partial void OnDepartmanIDChanging(int value);
    partial void OnDepartmanIDChanged();
    #endregion
		
		public POZISYON()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PozisyonAd", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PozisyonAd
		{
			get
			{
				return this._PozisyonAd;
			}
			set
			{
				if ((this._PozisyonAd != value))
				{
					this.OnPozisyonAdChanging(value);
					this.SendPropertyChanging();
					this._PozisyonAd = value;
					this.SendPropertyChanged("PozisyonAd");
					this.OnPozisyonAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmanID", DbType="Int NOT NULL")]
		public int DepartmanID
		{
			get
			{
				return this._DepartmanID;
			}
			set
			{
				if ((this._DepartmanID != value))
				{
					this.OnDepartmanIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmanID = value;
					this.SendPropertyChanged("DepartmanID");
					this.OnDepartmanIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MAAS")]
	public partial class MAA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _PersonelID;
		
		private int _Miktar;
		
		private int _YIL;
		
		private int _Ay_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPersonelIDChanging(int value);
    partial void OnPersonelIDChanged();
    partial void OnMiktarChanging(int value);
    partial void OnMiktarChanged();
    partial void OnYILChanging(int value);
    partial void OnYILChanged();
    partial void OnAy_IDChanging(int value);
    partial void OnAy_IDChanged();
    #endregion
		
		public MAA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonelID", DbType="Int NOT NULL")]
		public int PersonelID
		{
			get
			{
				return this._PersonelID;
			}
			set
			{
				if ((this._PersonelID != value))
				{
					this.OnPersonelIDChanging(value);
					this.SendPropertyChanging();
					this._PersonelID = value;
					this.SendPropertyChanged("PersonelID");
					this.OnPersonelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Miktar", DbType="Int NOT NULL")]
		public int Miktar
		{
			get
			{
				return this._Miktar;
			}
			set
			{
				if ((this._Miktar != value))
				{
					this.OnMiktarChanging(value);
					this.SendPropertyChanging();
					this._Miktar = value;
					this.SendPropertyChanged("Miktar");
					this.OnMiktarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YIL", DbType="Int NOT NULL")]
		public int YIL
		{
			get
			{
				return this._YIL;
			}
			set
			{
				if ((this._YIL != value))
				{
					this.OnYILChanging(value);
					this.SendPropertyChanging();
					this._YIL = value;
					this.SendPropertyChanged("YIL");
					this.OnYILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ay_ID", DbType="Int NOT NULL")]
		public int Ay_ID
		{
			get
			{
				return this._Ay_ID;
			}
			set
			{
				if ((this._Ay_ID != value))
				{
					this.OnAy_IDChanging(value);
					this.SendPropertyChanging();
					this._Ay_ID = value;
					this.SendPropertyChanged("Ay_ID");
					this.OnAy_IDChanged();
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
