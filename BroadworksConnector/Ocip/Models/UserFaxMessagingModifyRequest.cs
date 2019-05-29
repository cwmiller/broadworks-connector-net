using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFaxMessagingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = true)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "sipAliasList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementSIPAliasList SipAliasList { get; set; }
 }
}
