using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserHotelingGuestSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userHotelingGuestTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserHotelingGuestTable { get; set; }
 }
}
