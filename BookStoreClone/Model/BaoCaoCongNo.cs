
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BookStoreClone.Model
{

using System;
    using System.Collections.Generic;
    
public partial class BaoCaoCongNo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BaoCaoCongNo()
    {

        this.CTBaoCaoCongNoes = new HashSet<CTBaoCaoCongNo>();

    }


    public int MaBaoCao { get; set; }

    public int Thang { get; set; }

    public int Nam { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CTBaoCaoCongNo> CTBaoCaoCongNoes { get; set; }

}

}
