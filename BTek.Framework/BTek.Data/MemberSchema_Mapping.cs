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
    
    internal partial class MemberSchema_Mapping : EntityTypeConfiguration<MemberSchema>
    {
        public MemberSchema_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("MemberSchema");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.C_id).HasColumnName("_id");
    		this.Property(t => t.LastSvrUpdateDate).HasColumnName("LastSvrUpdateDate");
    		this.Property(t => t.OrgId).HasColumnName("OrgId");
    		this.Property(t => t.UserId).HasColumnName("UserId");
    		this.Property(t => t.RoleId).HasColumnName("RoleId");
    		this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
    		this.Property(t => t.IsOwner).HasColumnName("IsOwner");
    		this.Property(t => t.Status).HasColumnName("Status").IsRequired().HasMaxLength(50);
    		this.HasOptional(t => t.OrganisationSchema).WithMany(t => t.MemberSchemas).HasForeignKey(d => d.OrgId);
    		this.HasOptional(t => t.RoleSchema).WithMany(t => t.MemberSchemas).HasForeignKey(d => d.RoleId);
    		this.HasOptional(t => t.ScheduleSchema).WithMany(t => t.MemberSchemas).HasForeignKey(d => d.ScheduleId);
    		this.HasOptional(t => t.UserSchema).WithMany(t => t.MemberSchemas).HasForeignKey(d => d.UserId);
    	}
    }
}
