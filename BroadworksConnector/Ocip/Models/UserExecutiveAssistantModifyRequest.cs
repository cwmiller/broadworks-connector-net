using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveAssistantModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "enableDivert", IsNullable = false)]
    public bool EnableDivert { get; set; }
    [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = true)]
    public string DivertToPhoneNumber { get; set; }
    [XmlElement(ElementName = "optInStatus", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExecutiveAssistantOptInStatus> OptInStatus { get; set; }
 }
}
