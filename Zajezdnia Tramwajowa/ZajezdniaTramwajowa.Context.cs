﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zajezdnia_Tramwajowa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ZajezdniaTramwajowaEntities : DbContext
    {
        public ZajezdniaTramwajowaEntities()
            : base("name=ZajezdniaTramwajowaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Maszynista> Maszynista { get; set; }
        public virtual DbSet<Przejazd> Przejazd { get; set; }
        public virtual DbSet<Przystanek> Przystanek { get; set; }
        public virtual DbSet<Tramwaj> Tramwaj { get; set; }
        public virtual DbSet<Trasa> Trasa { get; set; }
        public virtual DbSet<uzyciePrzystankow> uzyciePrzystankows { get; set; }
    
        public virtual int InsertMaszynista(Nullable<decimal> stawka, string imie, string nazwisko)
        {
            var stawkaParameter = stawka.HasValue ?
                new ObjectParameter("stawka", stawka) :
                new ObjectParameter("stawka", typeof(decimal));
    
            var imieParameter = imie != null ?
                new ObjectParameter("imie", imie) :
                new ObjectParameter("imie", typeof(string));
    
            var nazwiskoParameter = nazwisko != null ?
                new ObjectParameter("nazwisko", nazwisko) :
                new ObjectParameter("nazwisko", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMaszynista", stawkaParameter, imieParameter, nazwiskoParameter);
        }
    }
}
