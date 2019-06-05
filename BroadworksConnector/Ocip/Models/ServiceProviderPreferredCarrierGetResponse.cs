using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _intraLataCarrier;

    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
    public string IntraLataCarrier {
        get => _intraLataCarrier;
        set {
            IntraLataCarrierSpecified = true;
            _intraLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool IntraLataCarrierSpecified { get; set; }
    private string _interLataCarrier;

    [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
    public string InterLataCarrier {
        get => _interLataCarrier;
        set {
            InterLataCarrierSpecified = true;
            _interLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool InterLataCarrierSpecified { get; set; }
    private string _internationalCarrier;

    [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
    public string InternationalCarrier {
        get => _internationalCarrier;
        set {
            InternationalCarrierSpecified = true;
            _internationalCarrier = value;
        }
    }

    [XmlIgnore]
    public bool InternationalCarrierSpecified { get; set; }
}
}
