using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false)]
    public bool EnableDirectoryPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantExtensionDialingPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantNameDialingPrivacy { get; set; }
    [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false)]
    public bool EnablePhoneStatusPrivacy { get; set; }
    [XmlElement(ElementName = "permittedMonitorUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList PermittedMonitorUserIdList { get; set; }
 }
}
