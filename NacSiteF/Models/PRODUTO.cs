//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NacSiteF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUTO
    {
        public int ID_PRODUTO { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public Nullable<int> ANO { get; set; }
        public Nullable<int> QUANTIDADE { get; set; }
        public Nullable<decimal> PRECO { get; set; }
    }
}
