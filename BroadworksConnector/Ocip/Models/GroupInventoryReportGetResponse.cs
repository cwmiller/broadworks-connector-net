using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInventoryReportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _inventoryReportTable;

    [XmlElement(ElementName = "inventoryReportTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable InventoryReportTable {
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
