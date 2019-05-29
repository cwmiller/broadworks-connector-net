using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCapacityManagementAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false)]
    public int MaxActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false)]
    public int MaxIncomingActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false)]
    public int MaxOutgoingActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "becomeDefaultGroupForNewUsers", IsNullable = false)]
    public bool BecomeDefaultGroupForNewUsers { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public List<string> UserId { get; set; }
 }
}
