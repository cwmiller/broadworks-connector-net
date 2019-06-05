using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDialableCallerIDModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> _criteriaPriorityOrder;

    [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder {
        get => _criteriaPriorityOrder;
        set {
            CriteriaPriorityOrderSpecified = true;
            _criteriaPriorityOrder = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaPriorityOrderSpecified { get; set; }
}
}
