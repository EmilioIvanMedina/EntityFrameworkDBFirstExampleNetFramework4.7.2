//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkInfrastructure.DataBaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class page_title
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public page_title()
        {
            this.page_sub_title = new HashSet<page_sub_title>();
        }
    
        public int id_page_title { get; set; }
        public string title { get; set; }
        public string title_description { get; set; }
        public string button_link_text { get; set; }
        public string linkUrl { get; set; }
        public Nullable<int> id_menu_item { get; set; }
    
        public virtual menu_item menu_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<page_sub_title> page_sub_title { get; set; }
    }
}
