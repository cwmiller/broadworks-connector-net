using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkAddInstanceRequest16sp2 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public List<string> UserId { get; set; }
    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false)]
    public string RecallAlternateUserId { get; set; }
    [XmlElement(ElementName = "recallTo", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallParkRecallTo RecallTo { get; set; }
 }
}
