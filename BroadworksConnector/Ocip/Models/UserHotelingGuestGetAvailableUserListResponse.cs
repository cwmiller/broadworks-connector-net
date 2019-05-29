using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingGuestGetAvailableUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "hostUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable HostUserTable { get; set; }
 }
}
