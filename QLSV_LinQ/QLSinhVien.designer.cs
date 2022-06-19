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

namespace QLSV_LinQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSinhVien")]
	public partial class QLSinhVienDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertDiem(Diem instance);
    partial void UpdateDiem(Diem instance);
    partial void DeleteDiem(Diem instance);
    partial void InsertKhoa(Khoa instance);
    partial void UpdateKhoa(Khoa instance);
    partial void DeleteKhoa(Khoa instance);
    partial void InsertLop(Lop instance);
    partial void UpdateLop(Lop instance);
    partial void DeleteLop(Lop instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public QLSinhVienDataContext() : 
				base(global::QLSV_LinQ.Properties.Settings.Default.QLSinhVienConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLSinhVienDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSinhVienDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSinhVienDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSinhVienDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Diem> Diems
		{
			get
			{
				return this.GetTable<Diem>();
			}
		}
		
		public System.Data.Linq.Table<Khoa> Khoas
		{
			get
			{
				return this.GetTable<Khoa>();
			}
		}
		
		public System.Data.Linq.Table<Lop> Lops
		{
			get
			{
				return this.GetTable<Lop>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maAdmin;
		
		private string _tenDangNhap;
		
		private string _matKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaAdminChanging(int value);
    partial void OnmaAdminChanged();
    partial void OntenDangNhapChanging(string value);
    partial void OntenDangNhapChanged();
    partial void OnmatKhauChanging(string value);
    partial void OnmatKhauChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maAdmin", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maAdmin
		{
			get
			{
				return this._maAdmin;
			}
			set
			{
				if ((this._maAdmin != value))
				{
					this.OnmaAdminChanging(value);
					this.SendPropertyChanging();
					this._maAdmin = value;
					this.SendPropertyChanged("maAdmin");
					this.OnmaAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenDangNhap", DbType="VarChar(50)")]
		public string tenDangNhap
		{
			get
			{
				return this._tenDangNhap;
			}
			set
			{
				if ((this._tenDangNhap != value))
				{
					this.OntenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._tenDangNhap = value;
					this.SendPropertyChanged("tenDangNhap");
					this.OntenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matKhau", DbType="VarChar(50)")]
		public string matKhau
		{
			get
			{
				return this._matKhau;
			}
			set
			{
				if ((this._matKhau != value))
				{
					this.OnmatKhauChanging(value);
					this.SendPropertyChanging();
					this._matKhau = value;
					this.SendPropertyChanged("matKhau");
					this.OnmatKhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Diem")]
	public partial class Diem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _maMH;
		
		private System.Nullable<int> _maSV;
		
		private System.Nullable<int> _maKhoa;
		
		private System.Nullable<double> _diemQT;
		
		private System.Nullable<double> _diemThi;
		
		private System.Nullable<int> _status;
		
		private EntityRef<Khoa> _Khoa;
		
		private EntityRef<MonHoc> _MonHoc;
		
		private EntityRef<SinhVien> _SinhVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaMHChanging(System.Nullable<int> value);
    partial void OnmaMHChanged();
    partial void OnmaSVChanging(System.Nullable<int> value);
    partial void OnmaSVChanged();
    partial void OnmaKhoaChanging(System.Nullable<int> value);
    partial void OnmaKhoaChanged();
    partial void OndiemQTChanging(System.Nullable<double> value);
    partial void OndiemQTChanged();
    partial void OndiemThiChanging(System.Nullable<double> value);
    partial void OndiemThiChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    #endregion
		
		public Diem()
		{
			this._Khoa = default(EntityRef<Khoa>);
			this._MonHoc = default(EntityRef<MonHoc>);
			this._SinhVien = default(EntityRef<SinhVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maMH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public System.Nullable<int> maMH
		{
			get
			{
				return this._maMH;
			}
			set
			{
				if ((this._maMH != value))
				{
					if (this._MonHoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaMHChanging(value);
					this.SendPropertyChanging();
					this._maMH = value;
					this.SendPropertyChanged("maMH");
					this.OnmaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public System.Nullable<int> maSV
		{
			get
			{
				return this._maSV;
			}
			set
			{
				if ((this._maSV != value))
				{
					if (this._SinhVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaSVChanging(value);
					this.SendPropertyChanging();
					this._maSV = value;
					this.SendPropertyChanged("maSV");
					this.OnmaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maKhoa", DbType="Int")]
		public System.Nullable<int> maKhoa
		{
			get
			{
				return this._maKhoa;
			}
			set
			{
				if ((this._maKhoa != value))
				{
					if (this._Khoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaKhoaChanging(value);
					this.SendPropertyChanging();
					this._maKhoa = value;
					this.SendPropertyChanged("maKhoa");
					this.OnmaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diemQT", DbType="Float")]
		public System.Nullable<double> diemQT
		{
			get
			{
				return this._diemQT;
			}
			set
			{
				if ((this._diemQT != value))
				{
					this.OndiemQTChanging(value);
					this.SendPropertyChanging();
					this._diemQT = value;
					this.SendPropertyChanged("diemQT");
					this.OndiemQTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diemThi", DbType="Float")]
		public System.Nullable<double> diemThi
		{
			get
			{
				return this._diemThi;
			}
			set
			{
				if ((this._diemThi != value))
				{
					this.OndiemThiChanging(value);
					this.SendPropertyChanging();
					this._diemThi = value;
					this.SendPropertyChanged("diemThi");
					this.OndiemThiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Diem", Storage="_Khoa", ThisKey="maKhoa", OtherKey="maKhoa", IsForeignKey=true)]
		public Khoa Khoa
		{
			get
			{
				return this._Khoa.Entity;
			}
			set
			{
				Khoa previousValue = this._Khoa.Entity;
				if (((previousValue != value) 
							|| (this._Khoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khoa.Entity = null;
						previousValue.Diems.Remove(this);
					}
					this._Khoa.Entity = value;
					if ((value != null))
					{
						value.Diems.Add(this);
						this._maKhoa = value.maKhoa;
					}
					else
					{
						this._maKhoa = default(Nullable<int>);
					}
					this.SendPropertyChanged("Khoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_Diem", Storage="_MonHoc", ThisKey="maMH", OtherKey="maMH", IsForeignKey=true)]
		public MonHoc MonHoc
		{
			get
			{
				return this._MonHoc.Entity;
			}
			set
			{
				MonHoc previousValue = this._MonHoc.Entity;
				if (((previousValue != value) 
							|| (this._MonHoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MonHoc.Entity = null;
						previousValue.Diems.Remove(this);
					}
					this._MonHoc.Entity = value;
					if ((value != null))
					{
						value.Diems.Add(this);
						this._maMH = value.maMH;
					}
					else
					{
						this._maMH = default(Nullable<int>);
					}
					this.SendPropertyChanged("MonHoc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_Diem", Storage="_SinhVien", ThisKey="maSV", OtherKey="maSV", IsForeignKey=true)]
		public SinhVien SinhVien
		{
			get
			{
				return this._SinhVien.Entity;
			}
			set
			{
				SinhVien previousValue = this._SinhVien.Entity;
				if (((previousValue != value) 
							|| (this._SinhVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SinhVien.Entity = null;
						previousValue.Diems.Remove(this);
					}
					this._SinhVien.Entity = value;
					if ((value != null))
					{
						value.Diems.Add(this);
						this._maSV = value.maSV;
					}
					else
					{
						this._maSV = default(Nullable<int>);
					}
					this.SendPropertyChanged("SinhVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khoa")]
	public partial class Khoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maKhoa;
		
		private string _tenKhoa;
		
		private System.Nullable<int> _namBatDau;
		
		private System.Nullable<int> _namKetThuc;
		
		private System.Nullable<int> _status;
		
		private EntitySet<Diem> _Diems;
		
		private EntitySet<Lop> _Lops;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaKhoaChanging(int value);
    partial void OnmaKhoaChanged();
    partial void OntenKhoaChanging(string value);
    partial void OntenKhoaChanged();
    partial void OnnamBatDauChanging(System.Nullable<int> value);
    partial void OnnamBatDauChanged();
    partial void OnnamKetThucChanging(System.Nullable<int> value);
    partial void OnnamKetThucChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    #endregion
		
		public Khoa()
		{
			this._Diems = new EntitySet<Diem>(new Action<Diem>(this.attach_Diems), new Action<Diem>(this.detach_Diems));
			this._Lops = new EntitySet<Lop>(new Action<Lop>(this.attach_Lops), new Action<Lop>(this.detach_Lops));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maKhoa", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maKhoa
		{
			get
			{
				return this._maKhoa;
			}
			set
			{
				if ((this._maKhoa != value))
				{
					this.OnmaKhoaChanging(value);
					this.SendPropertyChanging();
					this._maKhoa = value;
					this.SendPropertyChanged("maKhoa");
					this.OnmaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKhoa", DbType="NVarChar(50)")]
		public string tenKhoa
		{
			get
			{
				return this._tenKhoa;
			}
			set
			{
				if ((this._tenKhoa != value))
				{
					this.OntenKhoaChanging(value);
					this.SendPropertyChanging();
					this._tenKhoa = value;
					this.SendPropertyChanged("tenKhoa");
					this.OntenKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namBatDau", DbType="Int")]
		public System.Nullable<int> namBatDau
		{
			get
			{
				return this._namBatDau;
			}
			set
			{
				if ((this._namBatDau != value))
				{
					this.OnnamBatDauChanging(value);
					this.SendPropertyChanging();
					this._namBatDau = value;
					this.SendPropertyChanged("namBatDau");
					this.OnnamBatDauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namKetThuc", DbType="Int")]
		public System.Nullable<int> namKetThuc
		{
			get
			{
				return this._namKetThuc;
			}
			set
			{
				if ((this._namKetThuc != value))
				{
					this.OnnamKetThucChanging(value);
					this.SendPropertyChanging();
					this._namKetThuc = value;
					this.SendPropertyChanged("namKetThuc");
					this.OnnamKetThucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Diem", Storage="_Diems", ThisKey="maKhoa", OtherKey="maKhoa")]
		public EntitySet<Diem> Diems
		{
			get
			{
				return this._Diems;
			}
			set
			{
				this._Diems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Lops", ThisKey="maKhoa", OtherKey="maKhoa")]
		public EntitySet<Lop> Lops
		{
			get
			{
				return this._Lops;
			}
			set
			{
				this._Lops.Assign(value);
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
		
		private void attach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = this;
		}
		
		private void detach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = null;
		}
		
		private void attach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = this;
		}
		
		private void detach_Lops(Lop entity)
		{
			this.SendPropertyChanging();
			entity.Khoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lop")]
	public partial class Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maLop;
		
		private System.Nullable<int> _maKhoa;
		
		private string _tenNganh;
		
		private string _tenLop;
		
		private System.Nullable<int> _status;
		
		private EntitySet<SinhVien> _SinhViens;
		
		private EntityRef<Khoa> _Khoa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaLopChanging(int value);
    partial void OnmaLopChanged();
    partial void OnmaKhoaChanging(System.Nullable<int> value);
    partial void OnmaKhoaChanged();
    partial void OntenNganhChanging(string value);
    partial void OntenNganhChanged();
    partial void OntenLopChanging(string value);
    partial void OntenLopChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    #endregion
		
		public Lop()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			this._Khoa = default(EntityRef<Khoa>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLop", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maLop
		{
			get
			{
				return this._maLop;
			}
			set
			{
				if ((this._maLop != value))
				{
					this.OnmaLopChanging(value);
					this.SendPropertyChanging();
					this._maLop = value;
					this.SendPropertyChanged("maLop");
					this.OnmaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maKhoa", DbType="Int")]
		public System.Nullable<int> maKhoa
		{
			get
			{
				return this._maKhoa;
			}
			set
			{
				if ((this._maKhoa != value))
				{
					if (this._Khoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaKhoaChanging(value);
					this.SendPropertyChanging();
					this._maKhoa = value;
					this.SendPropertyChanged("maKhoa");
					this.OnmaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenNganh", DbType="NVarChar(50)")]
		public string tenNganh
		{
			get
			{
				return this._tenNganh;
			}
			set
			{
				if ((this._tenNganh != value))
				{
					this.OntenNganhChanging(value);
					this.SendPropertyChanging();
					this._tenNganh = value;
					this.SendPropertyChanged("tenNganh");
					this.OntenNganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenLop", DbType="VarChar(50)")]
		public string tenLop
		{
			get
			{
				return this._tenLop;
			}
			set
			{
				if ((this._tenLop != value))
				{
					this.OntenLopChanging(value);
					this.SendPropertyChanging();
					this._tenLop = value;
					this.SendPropertyChanged("tenLop");
					this.OntenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_SinhViens", ThisKey="maLop", OtherKey="maLop")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khoa_Lop", Storage="_Khoa", ThisKey="maKhoa", OtherKey="maKhoa", IsForeignKey=true)]
		public Khoa Khoa
		{
			get
			{
				return this._Khoa.Entity;
			}
			set
			{
				Khoa previousValue = this._Khoa.Entity;
				if (((previousValue != value) 
							|| (this._Khoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khoa.Entity = null;
						previousValue.Lops.Remove(this);
					}
					this._Khoa.Entity = value;
					if ((value != null))
					{
						value.Lops.Add(this);
						this._maKhoa = value.maKhoa;
					}
					else
					{
						this._maKhoa = default(Nullable<int>);
					}
					this.SendPropertyChanged("Khoa");
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maMH;
		
		private string _tenMH;
		
		private System.Nullable<int> _soTinChi;
		
		private System.Nullable<int> _status;
		
		private EntitySet<Diem> _Diems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaMHChanging(int value);
    partial void OnmaMHChanged();
    partial void OntenMHChanging(string value);
    partial void OntenMHChanged();
    partial void OnsoTinChiChanging(System.Nullable<int> value);
    partial void OnsoTinChiChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    #endregion
		
		public MonHoc()
		{
			this._Diems = new EntitySet<Diem>(new Action<Diem>(this.attach_Diems), new Action<Diem>(this.detach_Diems));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maMH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maMH
		{
			get
			{
				return this._maMH;
			}
			set
			{
				if ((this._maMH != value))
				{
					this.OnmaMHChanging(value);
					this.SendPropertyChanging();
					this._maMH = value;
					this.SendPropertyChanged("maMH");
					this.OnmaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenMH", DbType="NVarChar(100)")]
		public string tenMH
		{
			get
			{
				return this._tenMH;
			}
			set
			{
				if ((this._tenMH != value))
				{
					this.OntenMHChanging(value);
					this.SendPropertyChanging();
					this._tenMH = value;
					this.SendPropertyChanged("tenMH");
					this.OntenMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soTinChi", DbType="Int")]
		public System.Nullable<int> soTinChi
		{
			get
			{
				return this._soTinChi;
			}
			set
			{
				if ((this._soTinChi != value))
				{
					this.OnsoTinChiChanging(value);
					this.SendPropertyChanging();
					this._soTinChi = value;
					this.SendPropertyChanged("soTinChi");
					this.OnsoTinChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MonHoc_Diem", Storage="_Diems", ThisKey="maMH", OtherKey="maMH")]
		public EntitySet<Diem> Diems
		{
			get
			{
				return this._Diems;
			}
			set
			{
				this._Diems.Assign(value);
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
		
		private void attach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = this;
		}
		
		private void detach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.MonHoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maSV;
		
		private System.Nullable<int> _maLop;
		
		private string _email;
		
		private string _matKhau;
		
		private string _hoTen;
		
		private string _gioiTinh;
		
		private string _soDT;
		
		private string _diachi;
		
		private System.Nullable<int> _status;
		
		private EntitySet<Diem> _Diems;
		
		private EntityRef<Lop> _Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaSVChanging(int value);
    partial void OnmaSVChanged();
    partial void OnmaLopChanging(System.Nullable<int> value);
    partial void OnmaLopChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmatKhauChanging(string value);
    partial void OnmatKhauChanged();
    partial void OnhoTenChanging(string value);
    partial void OnhoTenChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnsoDTChanging(string value);
    partial void OnsoDTChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    #endregion
		
		public SinhVien()
		{
			this._Diems = new EntitySet<Diem>(new Action<Diem>(this.attach_Diems), new Action<Diem>(this.detach_Diems));
			this._Lop = default(EntityRef<Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maSV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maSV
		{
			get
			{
				return this._maSV;
			}
			set
			{
				if ((this._maSV != value))
				{
					this.OnmaSVChanging(value);
					this.SendPropertyChanging();
					this._maSV = value;
					this.SendPropertyChanged("maSV");
					this.OnmaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLop", DbType="Int")]
		public System.Nullable<int> maLop
		{
			get
			{
				return this._maLop;
			}
			set
			{
				if ((this._maLop != value))
				{
					if (this._Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaLopChanging(value);
					this.SendPropertyChanging();
					this._maLop = value;
					this.SendPropertyChanged("maLop");
					this.OnmaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matKhau", DbType="VarChar(50)")]
		public string matKhau
		{
			get
			{
				return this._matKhau;
			}
			set
			{
				if ((this._matKhau != value))
				{
					this.OnmatKhauChanging(value);
					this.SendPropertyChanging();
					this._matKhau = value;
					this.SendPropertyChanged("matKhau");
					this.OnmatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoTen", DbType="NVarChar(100)")]
		public string hoTen
		{
			get
			{
				return this._hoTen;
			}
			set
			{
				if ((this._hoTen != value))
				{
					this.OnhoTenChanging(value);
					this.SendPropertyChanging();
					this._hoTen = value;
					this.SendPropertyChanged("hoTen");
					this.OnhoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NVarChar(5)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soDT", DbType="Char(15)")]
		public string soDT
		{
			get
			{
				return this._soDT;
			}
			set
			{
				if ((this._soDT != value))
				{
					this.OnsoDTChanging(value);
					this.SendPropertyChanging();
					this._soDT = value;
					this.SendPropertyChanged("soDT");
					this.OnsoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(200)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SinhVien_Diem", Storage="_Diems", ThisKey="maSV", OtherKey="maSV")]
		public EntitySet<Diem> Diems
		{
			get
			{
				return this._Diems;
			}
			set
			{
				this._Diems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_Lop", ThisKey="maLop", OtherKey="maLop", IsForeignKey=true)]
		public Lop Lop
		{
			get
			{
				return this._Lop.Entity;
			}
			set
			{
				Lop previousValue = this._Lop.Entity;
				if (((previousValue != value) 
							|| (this._Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lop.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._Lop.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._maLop = value.maLop;
					}
					else
					{
						this._maLop = default(Nullable<int>);
					}
					this.SendPropertyChanged("Lop");
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
		
		private void attach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = this;
		}
		
		private void detach_Diems(Diem entity)
		{
			this.SendPropertyChanging();
			entity.SinhVien = null;
		}
	}
}
#pragma warning restore 1591
