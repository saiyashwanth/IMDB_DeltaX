//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeltaX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            this.Actor_Movie = new HashSet<Actor_Movie>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime YearofRelease { get; set; }
        public string Plot { get; set; }
        public byte[] Poster { get; set; }
        public int ProducerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor_Movie> Actor_Movie { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
