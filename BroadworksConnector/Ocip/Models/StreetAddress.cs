using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class StreetAddress 
{
    private string _addressLine1;

    [XmlElement(ElementName = "addressLine1", IsNullable = true, Namespace = "")]
    public string AddressLine1 {
        get => _addressLine1;
        set {
            AddressLine1Specified = true;
            _addressLine1 = value;
        }
    }

    [XmlIgnore]
    public bool AddressLine1Specified { get; set; }
    private string _addressLine2;

    [XmlElement(ElementName = "addressLine2", IsNullable = true, Namespace = "")]
    public string AddressLine2 {
        get => _addressLine2;
        set {
            AddressLine2Specified = true;
            _addressLine2 = value;
        }
    }

    [XmlIgnore]
    public bool AddressLine2Specified { get; set; }
    private string _city;

    [XmlElement(ElementName = "city", IsNullable = true, Namespace = "")]
    public string City {
        get => _city;
        set {
            CitySpecified = true;
            _city = value;
        }
    }

    [XmlIgnore]
    public bool CitySpecified { get; set; }
    private string _stateOrProvince;

    [XmlElement(ElementName = "stateOrProvince", IsNullable = true, Namespace = "")]
    public string StateOrProvince {
        get => _stateOrProvince;
        set {
            StateOrProvinceSpecified = true;
            _stateOrProvince = value;
        }
    }

    [XmlIgnore]
    public bool StateOrProvinceSpecified { get; set; }
    private string _stateOrProvinceDisplayName;

    [XmlElement(ElementName = "stateOrProvinceDisplayName", IsNullable = false, Namespace = "")]
    public string StateOrProvinceDisplayName {
        get => _stateOrProvinceDisplayName;
        set {
            StateOrProvinceDisplayNameSpecified = true;
            _stateOrProvinceDisplayName = value;
        }
    }

    [XmlIgnore]
    public bool StateOrProvinceDisplayNameSpecified { get; set; }
    private string _zipOrPostalCode;

    [XmlElement(ElementName = "zipOrPostalCode", IsNullable = true, Namespace = "")]
    public string ZipOrPostalCode {
        get => _zipOrPostalCode;
        set {
            ZipOrPostalCodeSpecified = true;
            _zipOrPostalCode = value;
        }
    }

    [XmlIgnore]
    public bool ZipOrPostalCodeSpecified { get; set; }
    private string _country;

    [XmlElement(ElementName = "country", IsNullable = true, Namespace = "")]
    public string Country {
        get => _country;
        set {
            CountrySpecified = true;
            _country = value;
        }
    }

    [XmlIgnore]
    public bool CountrySpecified { get; set; }
}
}
