//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileworxObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class FXFile
    {
        public string ID { get; set; }
        public string Body { get; set; }
    
        public virtual BusinessObject BusinessObject { get; set; }
        public virtual FXnew FXnew { get; set; }
        public virtual FXPhoto FXPhoto { get; set; }
    }
}