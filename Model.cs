using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFramework_LINQ {
    public class TripContext : DbContext {
        public DbSet<Trip> trips {get; set;}
        public DbSet<Parent> parents {get; set;}
        public DbSet<Student> students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=trip.db");
    }

    public class Trip {
        public int id { get; set; }
        public string Name { get; set; }

    }

    public class Parent {
        public int id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string LastName { get; set; }
        [StringLength(12, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string CellPhone { get; set; }

        public List<Student> Students {get;} = new List<Student>();
        public List<Trip> Trips {get; } = new List<Trip>();
    }

    public class Student {

        public int id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string LastName { get; set; }
        [StringLength(20, ErrorMessage = "The length of you entry is to long. Please try again.")]
        public string CellNumber { get; set; }


        public int ParentId { get; set; }
        public Parent Parent { get; set; }
        public List<Trip> Trips { get; } = new List<Trip>();

    }
}