using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInventoryReportGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _inventoryReportTable;

    [XmlElement(ElementName = "inventoryReportTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable InventoryReportTable {
        get => _inventoryReportTable;
        set {
            InventoryReportTableSpecified = true;
            _inventoryReportTable = value;
        }
    }

    [XmlIgnore]
    public bool InventoryReportTableSpecified { get; set; }
}
}
