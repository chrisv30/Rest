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
    
    internal partial class LogSchema_Mapping : EntityTypeConfiguration<LogSchema>
    {
        public LogSchema_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("LogSchema");
    		this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    		this.Property(t => t.C_id).HasColumnName("_id");
    		this.Property(t => t.LastSvrUpdateDate).HasColumnName("LastSvrUpdateDate");
    		this.Property(t => t.UserId).HasColumnName("UserId");
    		this.Property(t => t.Generated).HasColumnName("Generated");
    		this.Property(t => t.Object).HasColumnName("Object");
    		this.Property(t => t.Method).HasColumnName("Method").HasMaxLength(50);
    		this.Property(t => t.Severity).HasColumnName("Severity").HasMaxLength(50);
    		this.Property(t => t.Message).HasColumnName("Message");
    	}
    }
}
