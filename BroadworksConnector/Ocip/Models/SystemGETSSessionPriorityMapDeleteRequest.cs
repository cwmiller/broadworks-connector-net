using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSSessionPriorityMapDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _priorityLevel;

    [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
    public int PriorityLevel {
        get => _priorityLevel;
        set {
            PriorityLevelSpecified = true;
            _priorityLevel = value;
        }
    }

    [XmlIgnore]
    public bool PriorityLevelSpecified { get; set; }
}
}
