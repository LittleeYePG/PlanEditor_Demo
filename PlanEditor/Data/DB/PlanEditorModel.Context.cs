﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanEditor.Data.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlanEditorEntities : DbContext
    {
        public PlanEditorEntities()
            : base("name=PlanEditorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mstcalendar> mstcalendars { get; set; }
        public virtual DbSet<mstcalendardetail> mstcalendardetails { get; set; }
        public virtual DbSet<mstCapacityParam> mstCapacityParams { get; set; }
        public virtual DbSet<mstcompany> mstcompanies { get; set; }
        public virtual DbSet<mstitem> mstitems { get; set; }
        public virtual DbSet<mstitemcapacity> mstitemcapacities { get; set; }
        public virtual DbSet<mstline> mstlines { get; set; }
        public virtual DbSet<mstline_Marunix> mstline_Marunix { get; set; }
        public virtual DbSet<mstlinecalendar> mstlinecalendars { get; set; }
        public virtual DbSet<prgdmrp> prgdmrps { get; set; }
        public virtual DbSet<prgmmrp> prgmmrps { get; set; }
        public virtual DbSet<prgproductionorder> prgproductionorders { get; set; }
        public virtual DbSet<prgproductionresult> prgproductionresults { get; set; }
        public virtual DbSet<prgDownTimeDetail> prgDownTimeDetails { get; set; }
        public virtual DbSet<mstLine_WorkTime> mstLine_WorkTime { get; set; }
    }
}
