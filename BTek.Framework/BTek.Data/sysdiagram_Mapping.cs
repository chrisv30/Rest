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
    
    internal partial class sysdiagram_Mapping : EntityTypeConfiguration<sysdiagram>
    {
        public sysdiagram_Mapping()
        {					
    		this.HasKey(t => t.diagram_id);		
    		this.ToTable("sysdiagrams");
    		this.Property(t => t.name).HasColumnName("name").IsRequired().HasMaxLength(128);
    		this.Property(t => t.principal_id).HasColumnName("principal_id");
    		this.Property(t => t.diagram_id).HasColumnName("diagram_id");
    		this.Property(t => t.version).HasColumnName("version");
    		this.Property(t => t.definition).HasColumnName("definition");
    	}
    }
}
