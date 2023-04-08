﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudProcedure.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PracticeDbEntities2 : DbContext
    {
        public PracticeDbEntities2()
            : base("name=PracticeDbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblEmployeeProcedure> tblEmployeeProcedures { get; set; }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Create_Emp(string empName, string city, string gender, string email)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Create_Emp", empNameParameter, cityParameter, genderParameter, emailParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Create_Emp(string empName, string city, string gender, string email, MergeOption mergeOption)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Create_Emp", mergeOption, empNameParameter, cityParameter, genderParameter, emailParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Delete_Emp(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Delete_Emp", empidParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Delete_Emp(Nullable<int> empid, MergeOption mergeOption)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Delete_Emp", mergeOption, empidParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Details_Emp(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Details_Emp", empidParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Details_Emp(Nullable<int> empid, MergeOption mergeOption)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Details_Emp", mergeOption, empidParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Display_Emp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Display_Emp");
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Display_Emp(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Display_Emp", mergeOption);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Edit_Emp(string empName, string city, string gender, string email)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Edit_Emp", empNameParameter, cityParameter, genderParameter, emailParameter);
        }
    
        public virtual ObjectResult<tblEmployeeProcedure> SP_Edit_Emp(string empName, string city, string gender, string email, MergeOption mergeOption)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblEmployeeProcedure>("SP_Edit_Emp", mergeOption, empNameParameter, cityParameter, genderParameter, emailParameter);
        }
    }
}