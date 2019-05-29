using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanTransferNumbersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "useCustomSettings", IsNullable = false)]
    public bool UseCustomSettings { get; set; }
    [XmlElement(ElementName = "userNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify UserNumbers { get; set; }
 }
}
