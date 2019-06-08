using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VerifyTranslationAndRoutingParameters 
{
    private BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination _origination;

    [XmlElement(ElementName = "origination", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination Origination {
        get => _origination;
        set {
            OriginationSpecified = true;
            _origination = value;
        }
    }

    [XmlIgnore]
    public bool OriginationSpecified { get; set; }
    private string _destination;

    [XmlElement(ElementName = "destination", IsNullable = false, Namespace = "")]
    public string Destination {
        get => _destination;
        set {
            DestinationSpecified = true;
            _destination = value;
        }
    }

    [XmlIgnore]
    public bool DestinationSpecified { get; set; }
    private string _contact;

    [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
    public string Contact {
        get => _contact;
        set {
            ContactSpecified = true;
            _contact = value;
        }
    }

    [XmlIgnore]
    public bool ContactSpecified { get; set; }
    private string _diversion;

    [XmlElement(ElementName = "diversion", IsNullable = false, Namespace = "")]
    public string Diversion {
        get => _diversion;
        set {
            DiversionSpecified = true;
            _diversion = value;
        }
    }

    [XmlIgnore]
    public bool DiversionSpecified { get; set; }
}
}
