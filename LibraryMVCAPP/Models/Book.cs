//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMVCAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookFineTables = new HashSet<BookFineTable>();
            this.BookReturnTables = new HashSet<BookReturnTable>();
            this.PurchaseTables = new HashSet<PurchaseTable>();
            this.IssueBooks = new HashSet<IssueBook>();
        }
    
        public int BookID { get; set; }
        public int UserID { get; set; }
        public int BookTypeID { get; set; }
        public int DepartmentID { get; set; }
        public string BookTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public double Edition { get; set; }
        public int TotalCopies { get; set; }
        public System.DateTime RegDate { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookFineTable> BookFineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        public virtual BookType BookType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseTable> PurchaseTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueBook> IssueBooks { get; set; }
    }
}