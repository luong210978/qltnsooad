
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
    
public partial class NguoiDung
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NguoiDung()
    {

        this.HoaDons = new HashSet<HoaDon>();

        this.PhieuNhaps = new HashSet<PhieuNhap>();

        this.PhieuThuTiens = new HashSet<PhieuThuTien>();

    }


    public int MaND { get; set; }

    public string TenND { get; set; }

    public Nullable<System.DateTime> NgaySinh { get; set; }

    public Nullable<bool> GioiTinh { get; set; }

    public string DiaChi { get; set; }

    public string SDT { get; set; }

    public string TenDangNhap { get; set; }

    public string MatKhau { get; set; }

    public bool Admin { get; set; }

    public bool NhanVienKho { get; set; }

    public bool NhanVienBan { get; set; }

    public string img { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HoaDon> HoaDons { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PhieuThuTien> PhieuThuTiens { get; set; }

}

}