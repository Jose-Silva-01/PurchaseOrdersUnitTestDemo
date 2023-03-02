using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public class Address
    {
        private string street;
        private string city;
        private string province;
        private string postalCode;

        public string Street {
            get
            {
               return street;
            }
            set
            {
                if(AddressValidation.IsStreetValid(value) == false)
                {
                    throw new Exception("Invalid street, can't be blank");
                }

                street = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (AddressValidation.IsCityValid(value) == false)
                {
                    throw new Exception("Invalid city, can't be blank");
                }

                city = value;
            }
        }

        public string Province
        {
            get
            {
                return province;
            }
            set
            {
                if (AddressValidation.IsProvinceValid(value) == false)
                {
                    throw new Exception("Invalid province, can't be blank");
                }

                province = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                if (AddressValidation.IsPostalCodeValid(value) == false)
                {
                    throw new Exception("Invalid postal code, can't be blank");
                }

                postalCode = value;
            }
        }

        public bool IsValid()
        {
            // With this we make sure that if any of the properties aren't as we expected, 
            // the Address won't be valid.
            if (AddressValidation.IsPostalCodeValid(postalCode) == false || AddressValidation.IsCityValid(city) == false || AddressValidation.IsProvinceValid(province) == false || AddressValidation.IsStreetValid(street) == false)
                return false;

            return true;
        }
    }
}
