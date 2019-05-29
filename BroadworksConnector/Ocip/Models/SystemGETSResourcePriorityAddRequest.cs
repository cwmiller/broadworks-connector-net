using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSResourcePriorityAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "priorityValue", IsNullable = false)]
    public string PriorityValue { get; set; }
    [XmlElement(ElementName = "priorityLevel", IsNullable = false)]
    public int PriorityLevel { get; set; }
    [XmlElement(ElementName = "priorityClass", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GETSPriorityClass PriorityClass { get; set; }
 }
}
