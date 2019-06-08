using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _carrier;

    [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
    public string Carrier {
        get => _carrier;
        set {
            CarrierSpecified = true;
            _carrier = value;
        }
    }

    [XmlIgnore]
    public bool CarrierSpecified { get; set; }
    private string _cic;

    [XmlElement(ElementName = "cic", IsNullable = false, Namespace = "")]
    public string Cic {
        get => _cic;
        set {
            CicSpecified = true;
            _cic = value;
        }
    }

    [XmlIgnore]
    public bool CicSpecified { get; set; }
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
    private bool _isIntraLata;

    [XmlElement(ElementName = "isIntraLata", IsNullable = false, Namespace = "")]
    public bool IsIntraLata {
        get => _isIntraLata;
        set {
            IsIntraLataSpecified = true;
            _isIntraLata = value;
        }
    }

    [XmlIgnore]
    public bool IsIntraLataSpecified { get; set; }
    private bool _isInterLata;

    [XmlElement(ElementName = "isInterLata", IsNullable = false, Namespace = "")]
    public bool IsInterLata {
        get => _isInterLata;
        set {
            IsInterLataSpecified = true;
            _isInterLata = value;
        }
    }

    [XmlIgnore]
    public bool IsInterLataSpecified { get; set; }
    private bool _isInternational;

    [XmlElement(ElementName = "isInternational", IsNullable = false, Namespace = "")]
    public bool IsInternational {
        get => _isInternational;
        set {
            IsInternationalSpecified = true;
            _isInternational = value;
        }
    }

    [XmlIgnore]
    public bool IsInternationalSpecified { get; set; }
}
}
