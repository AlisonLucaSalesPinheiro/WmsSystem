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
    
    public partial class tblFornecedorItem
    {
        public int idFornecedorItem { get; set; }
        public int valorUnitario { get; set; }
        public int leadTime { get; set; }
        public int idProduto { get; set; }
        public int idFornecedor { get; set; }
    
        public virtual tblFornecedor tblFornecedor { get; set; }
        public virtual tblProduto tblProduto { get; set; }
    }
}