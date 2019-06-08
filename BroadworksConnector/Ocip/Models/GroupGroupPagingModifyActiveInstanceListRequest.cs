using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingModifyActiveInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.ServiceActivation> _serviceActivation;

    [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ServiceActivation> ServiceActivation {
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
