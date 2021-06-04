﻿namespace posUno.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Addres { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        public User User { get; set; }
    }
}
