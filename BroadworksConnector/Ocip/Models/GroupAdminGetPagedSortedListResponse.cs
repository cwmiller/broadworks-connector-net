using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdminGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupAdminTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupAdminTable { get; set; }
 }
}
