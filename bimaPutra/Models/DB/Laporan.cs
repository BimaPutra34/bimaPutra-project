//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp_mvc_2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laporan
    {
        public int id_laporan { get; set; }
        public int id_buku { get; set; }
        public int id_pelanggan { get; set; }
        public string keterangan { get; set; }
        public Nullable<System.DateTime> tanggal { get; set; }
        public int debet { get; set; }
        public int kredit { get; set; }
        public int saldo { get; set; }
    
        public virtual Buku Buku { get; set; }
        public virtual Pelanggan Pelanggan { get; set; }
    }
}
