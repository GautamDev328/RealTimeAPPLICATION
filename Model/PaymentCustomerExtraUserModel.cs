//1st Model
using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class PaymentCustomerExtraUserModel
    {
        [Key]
        public int id { get; set;}
        public string Device_Serials {get; set;}
        //public string? LicenceDays { get; set; } = 365day;
        //public string ValidForMonth { get; set; } = null;
        public string? GstTax { get; set; } = null;
        public string? OtherCharges { get; set; } = null;

    }
}

//Second model 

//using System;
//using System.ComponentModel.DataAnnotations;

//namespace CRUDAPPLICATION.Model
//{
//    public class PaymentCustomerExtraUserModel
//    {
//        [Key]
//        public int PaymentId { get; set; }

//        public string DeviceSerial { get; set; }

//        private int _licenceDays;
//        public int LicenceDays
//        {
//            get
//            {
//                return _licenceDays;
//            }
//            private set
//            {
//                int year = DateTime.Now.Year;
//                _licenceDays = DateTime.IsLeapYear(year) ? 366 : 365;
//            }
//        }

//        public string ValidForMonth { get; set; }
//        public string GstTax { get; set; }
//        public string OtherCharges { get; set; }

//        // Constructor to initialize LicenceDays
//        public PaymentCustomerExtraUserModel()
//        {
//            LicenceDays = 0; // This will trigger the setter and calculate the correct number of days.
//        }
//    }
//}

//using System;
//using System.ComponentModel.DataAnnotations;

//namespace CRUDAPPLICATION.Model
//{
//    public class PaymentCustomerExtraUserModel
//    {
//        [Key]
//        public int PaymentId { get; set; }

//        public string DeviceSerial { get; set; }

//        private int   _licenceDays;
//        public int   LicenceDays
//        {
//            get
//            {
//                return _licenceDays;
//            }
//            private set
//            {
//                int year = DateTime.Now.Year;
//                _licenceDays = DateTime.IsLeapYear(year) ? 366 : 365;
//            }
//        }

//        private int _validForMonth = 12;
//        public int ValidForMonth
//        {
//            get
//            {
//                return _validForMonth;
//            }
//            private set
//            {
//                _validForMonth = 12; // Fixed to 12 months
//            }
//        }

//        public string GstTax { get; set; }
//        public string OtherCharges { get; set; }

//        // Constructor to initialize LicenceDays and ValidForMonth
//        public PaymentCustomerExtraUserModel()
//        {
//            LicenceDays = 0; // This will trigger the setter and calculate the correct number of days.
//            ValidForMonth = 0; // This will trigger the setter and fix the value to 12.
//        }
//    }
//}
