using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceXmlModifyActiveInstanceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.ServiceActivation> _serviceActivation;

    [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceActivation> ServiceActivation {
        get => _serviceActivation;
        set {
            ServiceActivationSpecified = true;
            _serviceActivation = value;
        }
    }

    [XmlIgnore]
    public bool ServiceActivationSpecified { get; set; }
}
}
