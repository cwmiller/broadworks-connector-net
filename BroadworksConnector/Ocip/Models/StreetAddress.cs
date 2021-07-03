using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Street address information.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4696""}]")]
    public class StreetAddress
    {

        private string _addressLine1;

        [XmlElement(ElementName = "addressLine1", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AddressLine1
        {
            get => _addressLine1;
            set
            {
                AddressLine1Specified = true;
                _addressLine1 = value;
            }
        }

        [XmlIgnore]
        protected bool AddressLine1Specified { get; set; }

        private string _addressLine2;

        [XmlElement(ElementName = "addressLine2", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AddressLine2
        {
            get => _addressLine2;
            set
            {
                AddressLine2Specified = true;
                _addressLine2 = value;
            }
        }

        [XmlIgnore]
        protected bool AddressLine2Specified { get; set; }

        private string _city;

        [XmlElement(ElementName = "city", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(50)]
        public string City
        {
            get => _city;
            set
            {
                CitySpecified = true;
                _city = value;
            }
        }

        [XmlIgnore]
        protected bool CitySpecified { get; set; }

        private string _stateOrProvince;

        [XmlElement(ElementName = "stateOrProvince", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(50)]
        public string StateOrProvince
        {
            get => _stateOrProvince;
            set
            {
                StateOrProvinceSpecified = true;
                _stateOrProvince = value;
            }
        }

        [XmlIgnore]
        protected bool StateOrProvinceSpecified { get; set; }

        private string _stateOrProvinceDisplayName;

        [XmlElement(ElementName = "stateOrProvinceDisplayName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(50)]
        public string StateOrProvinceDisplayName
        {
            get => _stateOrProvinceDisplayName;
            set
            {
                StateOrProvinceDisplayNameSpecified = true;
                _stateOrProvinceDisplayName = value;
            }
        }

        [XmlIgnore]
        protected bool StateOrProvinceDisplayNameSpecified { get; set; }

        private string _zipOrPostalCode;

        [XmlElement(ElementName = "zipOrPostalCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(50)]
        public string ZipOrPostalCode
        {
            get => _zipOrPostalCode;
            set
            {
                ZipOrPostalCodeSpecified = true;
                _zipOrPostalCode = value;
            }
        }

        [XmlIgnore]
        protected bool ZipOrPostalCodeSpecified { get; set; }

        private string _country;

        [XmlElement(ElementName = "country", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4696")]
        [MinLength(1)]
        [MaxLength(50)]
        public string Country
        {
            get => _country;
            set
            {
                CountrySpecified = true;
                _country = value;
            }
        }

        [XmlIgnore]
        protected bool CountrySpecified { get; set; }

    }
}
