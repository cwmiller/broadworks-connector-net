using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "pagingGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PagingGroupTable { get; set; }
 }
}
