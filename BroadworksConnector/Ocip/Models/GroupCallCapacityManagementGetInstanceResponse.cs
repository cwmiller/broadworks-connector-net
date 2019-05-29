using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCapacityManagementGetInstanceResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false)]
    public int MaxActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false)]
    public int MaxIncomingActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false)]
    public int MaxOutgoingActiveCallsAllowed { get; set; }
    [XmlElement(ElementName = "defaultGroupForNewUsers", IsNullable = false)]
    public bool DefaultGroupForNewUsers { get; set; }
    [XmlElement(ElementName = "userTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable { get; set; }
 }
}
