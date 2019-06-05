using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreferredCarrierGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.GroupPreferredCarrierName _intraLataCarrier;

    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName IntraLataCarrier {
        get => _intraLataCarrier;
        set {
            IntraLataCarrierSpecified = true;
            _intraLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool IntraLataCarrierSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupPreferredCarrierName _interLataCarrier;

    [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName InterLataCarrier {
        get => _interLataCarrier;
        set {
            InterLataCarrierSpecified = true;
            _interLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool InterLataCarrierSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupPreferredCarrierName _internationalCarrier;

    [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName InternationalCarrier {
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
