//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTek.Data
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class UserSchema_Mapping : EntityTypeConfiguration<UserSchema>
    {
        public UserSchema_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("UserSchema");
    		this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    		this.Property(t => t.C_id).HasColumnName("_id");
    		this.Property(t => t.AddressId).HasColumnName("AddressId");
    		this.Property(t => t.LastSvrUpdateDate).HasColumnName("LastSvrUpdateDate");
    		this.Property(t => t.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Username).HasColumnName("Username").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Password).HasColumnName("Password").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Salt).HasColumnName("Salt").IsRequired().HasMaxLength(50);
    		this.Property(t => t.WPUserId).HasColumnName("WPUserId");
    		this.Property(t => t.FirstName).HasColumnName("FirstName").HasMaxLength(50);
    		this.Property(t => t.LastName).HasColumnName("LastName").HasMaxLength(50);
    		this.Property(t => t.Phone).HasColumnName("Phone").HasMaxLength(50);
    		this.Property(t => t.AccountType).HasColumnName("AccountType");
    		this.Property(t => t.AccountStatus).HasColumnName("AccountStatus");
    		this.Property(t => t.DateCreated).HasColumnName("DateCreated");
    		this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
    		this.Property(t => t.DateExpires).HasColumnName("DateExpires");
    		this.HasOptional(t => t.AddressSchema).WithMany(t => t.UserSchemas).HasForeignKey(d => d.AddressId);
    	}
    }
}
