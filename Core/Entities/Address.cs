﻿namespace Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public string PostalCode { get; set; }
    }
}