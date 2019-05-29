using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDnGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "dnTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DnTable { get; set; }
 }
}
