using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsSchemaInstanceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _schemaInstanceUsageTable;

    [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SchemaInstanceUsageTable {
        get => _schemaInstanceUsageTable;
        set {
            SchemaInstanceUsageTableSpecified = true;
            _schemaInstanceUsageTable = value;
        }
    }

    [XmlIgnore]
    public bool SchemaInstanceUsageTableSpecified { get; set; }
}
}
