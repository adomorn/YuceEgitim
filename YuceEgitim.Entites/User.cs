using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;

namespace YuceEgitim.Entites
{
    public class User : BaseEntity
    {
   
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
