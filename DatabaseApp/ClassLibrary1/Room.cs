//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public Room()
        {
            this.Screenings = new HashSet<Screening>();
        }
    
        public int RoomId { get; set; }
        public byte RoomNum { get; set; }
        public int Capacity { get; set; }
    
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
