using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MWIDeliveryToMobileEndpointTemplateBody 
{
    private List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> _line;

    [XmlElement(ElementName = "line", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> Line {
        get => _line;
        set {
            LineSpecified = true;
            _line = value;
        }
    }

    [XmlIgnore]
    public bool LineSpecified { get; set; }
}
}
