
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentFind.Entities
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
     
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
      
        public string Surname { get; set; }
        public int Number { get; set; }

    
    }
}
