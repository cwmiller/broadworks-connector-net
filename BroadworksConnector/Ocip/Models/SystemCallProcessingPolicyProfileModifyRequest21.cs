using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementCallProcessingPolicyProfileSubscriberTypeList21 _assignedSubscriberTypeList;

    [XmlElement(ElementName = "assignedSubscriberTypeList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementCallProcessingPolicyProfileSubscriberTypeList21 AssignedSubscriberTypeList {
        get => _assignedSubscriberTypeList;
        set {
            AssignedSubscriberTypeListSpecified = true;
            _assignedSubscriberTypeList = value;
        }
    }

    [XmlIgnore]
    public bool AssignedSubscriberTypeListSpecified { get; set; }
}
}
