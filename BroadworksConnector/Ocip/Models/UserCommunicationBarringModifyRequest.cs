using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommunicationBarringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "useGroupSetting", IsNullable = false)]
    public bool UseGroupSetting { get; set; }
    [XmlElement(ElementName = "profileName", IsNullable = true)]
    public string ProfileName { get; set; }
 }
}
