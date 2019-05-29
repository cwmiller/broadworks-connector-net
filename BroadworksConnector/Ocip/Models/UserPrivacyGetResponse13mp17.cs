using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetResponse13mp17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false)]
    public bool EnableDirectoryPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantExtensionDialingPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantNameDialingPrivacy { get; set; }
    [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false)]
    public bool EnablePhoneStatusPrivacy { get; set; }
    [XmlElement(ElementName = "permittedMonitorUserIdTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PermittedMonitorUserIdTable { get; set; }
 }
}
