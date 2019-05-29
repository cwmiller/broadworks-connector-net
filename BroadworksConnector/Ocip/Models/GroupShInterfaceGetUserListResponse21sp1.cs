using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupShInterfaceGetUserListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "entry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1> Entry { get; set; }
 }
}
