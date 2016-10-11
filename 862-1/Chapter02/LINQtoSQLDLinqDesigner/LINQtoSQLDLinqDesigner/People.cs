﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQtoSQLDLinqDesigner {
    
    
    public partial class PeopleDataContext : System.Data.DLinq.DataContext {
        
        public System.Data.DLinq.Table<Role> Roles;
        
        public System.Data.DLinq.Table<Person> Persons;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public PeopleDataContext() : 
                base(new System.Data.SqlClient.SqlConnection(global::LINQtoSQLDLinqDesigner.Properties.Settings.Default.DataConnection)) {
        }
    }
    
    [System.Data.DLinq.Table(Name="Role")]
    public partial class Role : System.Data.DLinq.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged {
        
        private int _ID;
        
        private string _RoleDescription;
        
        private System.Data.DLinq.EntitySet<Person> _Persons;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Role() {
            this._Persons = new System.Data.DLinq.EntitySet<Person>(new System.Data.DLinq.Notification<Person>(this.Attach_Persons), new System.Data.DLinq.Notification<Person>(this.Attach_Persons));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="ID", Storage="_ID", DBType="int NOT NULL IDENTITY", Id=true, AutoGen=true)]
        public virtual int ID {
            get {
                return this._ID;
            }
            set {
                if ((this._ID != value)) {
                    this.OnPropertyChanging("ID");
                    this._ID = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="RoleDescription", Storage="_RoleDescription", DBType="nvarchar NOT NULL")]
        public virtual string RoleDescription {
            get {
                return this._RoleDescription;
            }
            set {
                if ((this._RoleDescription != value)) {
                    this.OnPropertyChanging("RoleDescription");
                    this._RoleDescription = value;
                    this.OnPropertyChanged("RoleDescription");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Association(Name="FK_Person_Role", Storage="_Persons", OtherKey="IDRole")]
        public virtual System.Data.DLinq.EntitySet<Person> Persons {
            get {
                return this._Persons;
            }
            set {
                this._Persons.Assign(value);
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanging;
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected virtual void OnPropertyChanging(string propertyName) {
            if ((this.PropertyChanging != null)) {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) {
            if ((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void Attach_Persons(Person entity) {
            this.OnPropertyChanging(null);
            entity.Role = this;
            this.OnPropertyChanged(null);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void Detach_Persons(Person entity) {
            this.OnPropertyChanging(null);
            entity.Role = null;
            this.OnPropertyChanged(null);
        }
    }
    
    [System.Data.DLinq.Table(Name="Person")]
    public partial class Person : System.Data.DLinq.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged {
        
        private int _ID;
        
        private int _IDRole;
        
        private string _LastName;
        
        private string _FirstName;
        
        private System.Data.DLinq.EntityRef<Role> _Role;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Person() {
            this._Role = default(System.Data.DLinq.EntityRef<Role>);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="ID", Storage="_ID", DBType="int NOT NULL IDENTITY", Id=true, AutoGen=true)]
        public virtual int ID {
            get {
                return this._ID;
            }
            set {
                if ((this._ID != value)) {
                    this.OnPropertyChanging("ID");
                    this._ID = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="IDRole", Storage="_IDRole", DBType="int NOT NULL")]
        public virtual int IDRole {
            get {
                return this._IDRole;
            }
            set {
                if ((this._IDRole != value)) {
                    this.OnPropertyChanging("IDRole");
                    this._IDRole = value;
                    this.OnPropertyChanged("IDRole");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="LastName", Storage="_LastName", DBType="nvarchar NOT NULL")]
        public virtual string LastName {
            get {
                return this._LastName;
            }
            set {
                if ((this._LastName != value)) {
                    this.OnPropertyChanging("LastName");
                    this._LastName = value;
                    this.OnPropertyChanged("LastName");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Column(Name="FirstName", Storage="_FirstName", DBType="nvarchar NOT NULL")]
        public virtual string FirstName {
            get {
                return this._FirstName;
            }
            set {
                if ((this._FirstName != value)) {
                    this.OnPropertyChanging("FirstName");
                    this._FirstName = value;
                    this.OnPropertyChanged("FirstName");
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Data.DLinq.Association(Name="FK_Person_Role", Storage="_Role", ThisKey="IDRole", IsParent=true)]
        public Role Role {
            get {
                return this._Role.Entity;
            }
            set {
                if ((this._Role.Entity != value)) {
                    this.OnPropertyChanging("Role");
                    if ((this._Role.Entity != null)) {
                        this._Role.Entity = null;
                        this._Role.Entity.Persons.Remove(this);
                    }
                    this._Role.Entity = value;
                    if ((value != null)) {
                        value.Persons.Add(this);
                    }
                    this.OnPropertyChanged("Role");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanging;
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected virtual void OnPropertyChanging(string propertyName) {
            if ((this.PropertyChanging != null)) {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) {
            if ((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
