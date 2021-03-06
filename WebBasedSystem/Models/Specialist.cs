
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebBasedSystem.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Specialist
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Specialist()
    {

        this.Notes = new HashSet<Note>();

    }


    public int SpecialistId { get; set; }

    public string Title { get; set; }

    public string SpecialistName { get; set; }

    public string MobileNo { get; set; }

    public string PhoneNo { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string EmailAddress { get; set; }

    public string BusinessName { get; set; }

    public Nullable<int> SpecialistTypeId { get; set; }

    public string Surname { get; set; }

    public string OfficeNo { get; set; }

    public Nullable<bool> IsDeleted { get; set; }

    public string SubMenu { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Note> Notes { get; set; }

    public virtual SpecialistType SpecialistType { get; set; }

}

}
