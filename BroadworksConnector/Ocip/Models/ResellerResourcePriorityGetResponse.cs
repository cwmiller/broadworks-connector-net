using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerResourcePriorityGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSystemSettings", IsNullable = false)]
    public bool UseSystemSettings { get; set; }
    [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false)]
    public bool SendResourcePriorityToNetwork { get; set; }
    [XmlElement(ElementName = "resourcePriority", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue ResourcePriority { get; set; }
 }
}
