//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduto()
        {
            this.tblFornecedorItem = new HashSet<tblFornecedorItem>();
        }
    
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public Nullable<bool> statusProduto { get; set; }
        public int idPosicao { get; set; }
        public int idUnidade { get; set; }
        public int idTipo { get; set; }
        public int idGrupo { get; set; }
    
        public virtual tblGrupo tblGrupo { get; set; }
        public virtual tblPosicaoEstoque tblPosicaoEstoque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFornecedorItem> tblFornecedorItem { get; set; }
        public virtual tblTipo tblTipo { get; set; }
        public virtual tblUnidade tblUnidade { get; set; }
    }
}