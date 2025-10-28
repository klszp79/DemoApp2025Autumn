using System.ComponentModel.DataAnnotations;

namespace DemoApp2025Autumn.App
{
    public class Person
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Range(typeof(DateOnly), "1990-01-01","2000-12-31")]
        public DateOnly Birthday { get; set; }
    }
}
