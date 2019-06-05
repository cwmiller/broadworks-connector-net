using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceAccessCodeListName;

    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
    public string ServiceAccessCodeListName {
        get => _serviceAccessCodeListName;
        set {
            ServiceAccessCodeListNameSpecified = true;
            _serviceAccessCodeListName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessCodeListNameSpecified { get; set; }
    private string _countryCode;

    [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
    public string CountryCode {
        get => _countryCode;
        set {
            CountryCodeSpecified = true;
            _countryCode = value;
        }
    }

    [XmlIgnore]
    public bool CountryCodeSpecified { get; set; }
    private string _serviceAccessCode;

    [XmlElement(ElementName = "serviceAccessCode", IsNullable = false, Namespace = "")]
    public string ServiceAccessCode {
        get => _serviceAccessCode;
        set {
            ServiceAccessCodeSpecified = true;
            _serviceAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessCodeSpecified { get; set; }
}
}
