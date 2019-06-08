using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedServicePackAssignmentList 
{
    private List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> _servicePack;

    [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack {
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
