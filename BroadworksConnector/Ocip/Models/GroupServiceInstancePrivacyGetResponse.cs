using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceInstancePrivacyGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false)]
    public bool EnableDirectoryPrivacy { get; set; }
    [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false)]
    public bool EnableAutoAttendantExtensionDialingPrivacy { get; set; }
 }
}
