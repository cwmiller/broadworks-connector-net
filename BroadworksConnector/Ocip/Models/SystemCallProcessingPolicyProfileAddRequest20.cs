using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileAddRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> _assignedSubscriberType;

    [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> AssignedSubscriberType {
        get => _assignedSubscriberType;
        set {
            AssignedSubscriberTypeSpecified = true;
            _assignedSubscriberType = value;
        }
    }

    [XmlIgnore]
    public bool AssignedSubscriberTypeSpecified { get; set; }
}
}
