﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TccSenai
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbWmsEntities1 : DbContext
    {
        public dbWmsEntities1()
            : base("name=dbWmsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAvaliacao> tblAvaliacao { get; set; }
        public virtual DbSet<tblContato> tblContato { get; set; }
        public virtual DbSet<tblFornecedor> tblFornecedor { get; set; }
        public virtual DbSet<tblGrupo> tblGrupo { get; set; }
        public virtual DbSet<tblItemRecebido> tblItemRecebido { get; set; }
        public virtual DbSet<tblPosicaoEstoque> tblPosicaoEstoque { get; set; }
        public virtual DbSet<tblProduto> tblProduto { get; set; }
        public virtual DbSet<tblRecebimentoGerencial> tblRecebimentoGerencial { get; set; }
        public virtual DbSet<tblRecebimentoNf> tblRecebimentoNf { get; set; }
        public virtual DbSet<tblTipo> tblTipo { get; set; }
        public virtual DbSet<tblTipoGrupo> tblTipoGrupo { get; set; }
        public virtual DbSet<tblUnidade> tblUnidade { get; set; }
        public virtual DbSet<tblUsuario> tblUsuario { get; set; }
        public virtual DbSet<tblFornecedorItem> tblFornecedorItem { get; set; }
    }
}
