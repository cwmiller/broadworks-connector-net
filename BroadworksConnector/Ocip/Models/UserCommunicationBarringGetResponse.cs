using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommunicationBarringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useGroupSetting", IsNullable = false)]
    public bool UseGroupSetting { get; set; }
    [XmlElement(ElementName = "profileName", IsNullable = false)]
    public string ProfileName { get; set; }
 }
}
