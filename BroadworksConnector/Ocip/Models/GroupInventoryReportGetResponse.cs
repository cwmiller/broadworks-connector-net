using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInventoryReportGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "inventoryReportTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable InventoryReportTable { get; set; }
 }
}
