using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNList OutgoingSMDIMWIPhoneNumberList { get; set; }
 }
}
