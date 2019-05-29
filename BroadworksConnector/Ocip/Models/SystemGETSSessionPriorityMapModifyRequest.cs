using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSSessionPriorityMapModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "priorityLevel", IsNullable = false)]
    public int PriorityLevel { get; set; }
    [XmlElement(ElementName = "sessionPriority", IsNullable = false)]
    public int SessionPriority { get; set; }
 }
}
