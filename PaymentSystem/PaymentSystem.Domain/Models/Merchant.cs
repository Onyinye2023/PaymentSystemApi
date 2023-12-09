using PaymentSystem.Domain.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Domain.Models
{
    public class Merchant
    {
        [Key]
        public string MerchantNumber { get; set; }
        public string BusinessIdNumber { get; set; }
        public string BusinessName { get; set; }
        public string MerchantName { get; set; }
        public string MerchantSurname { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public decimal AverageTransactionVolume { get; set; }
       
    }



    //TODO: Add Date of establishment validation

    //public static Business AddBusi(DateTime dateOfE)
    //{
    //    var validator = new BusinessValidator();
    //    var objToValidate = new Business
    //    {
    //        DateOfEstablishment = dateOfE
    //    };


    //    //business.DateOfEstablishment = DateTime.Now; // This will trigger a validation error.
    //}
}
