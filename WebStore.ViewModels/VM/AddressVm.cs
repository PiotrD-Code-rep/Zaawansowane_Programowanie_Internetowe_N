using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels.VM
{
    public class AddressVm
    {
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Street { get; set; }
        public int BuildingNumber { get; set; }
        public int? ApartmentNumber { get; set; }
    }
}