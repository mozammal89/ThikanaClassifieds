//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThikanaClassifieds.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classifieds_Item_Image
    {
        public int Classifieds_Item_Image_Id { get; set; }
        public int Classifieds_Item_Id { get; set; }
        public string Classifieds_Item_Image1 { get; set; }
    
        public virtual Classifieds_Items Classifieds_Items { get; set; }
    }
}