using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> _assignedSubscriberType;

    [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> AssignedSubscriberType {
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
