using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedUserServiceAssignmentList 
{
    private List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _userServiceServiceName;

    [XmlElement(ElementName = "userServiceServiceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserServiceServiceName {
        get => _userServiceServiceName;
        set {
            UserServiceServiceNameSpecified = true;
            _userServiceServiceName = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceServiceNameSpecified { get; set; }
}
}
