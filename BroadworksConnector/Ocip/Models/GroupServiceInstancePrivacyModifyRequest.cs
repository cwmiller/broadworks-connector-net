using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceInstancePrivacyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false)]
    public bool EnableDirectoryPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantExtensionDialingPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantNameDialingPrivacy { get; set; }
 }
}
