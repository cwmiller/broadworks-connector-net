using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EnterpriseTrunkUserTable { get; set; }
 }
}
