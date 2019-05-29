using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetOriginatorListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "originatorTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable OriginatorTable { get; set; }
 }
}
