﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required] 
        [StringLength(maximumLength:50,ErrorMessage = "Long Name is too long")]
        public string Name { get; set; }
        [Required] 
        [StringLength(maximumLength:3,ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO:CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }

    public class UpdateCountrylDTO:CreateCountryDTO
    {
        public IList<CreateHotelDTO> Hotels { get; set; }
    }

   
}