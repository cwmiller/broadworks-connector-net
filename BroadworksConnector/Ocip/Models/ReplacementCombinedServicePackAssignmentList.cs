using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedServicePackAssignmentList 
{
    private List<BroadworksConnector.Ocip.Models.CombinedServicePackAssignment> _servicePack;

    [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CombinedServicePackAssignment> ServicePack {
        get => _servicePack;
        set {
            ServicePackSpecified = true;
            _servicePack = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackSpecified { get; set; }
}
}
