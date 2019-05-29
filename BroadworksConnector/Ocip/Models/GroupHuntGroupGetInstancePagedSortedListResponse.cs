using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstancePagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "huntGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable HuntGroupTable { get; set; }
 }
}
