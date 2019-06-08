using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileAddRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> _assignedSubscriberType;

    [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> AssignedSubscriberType {
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
