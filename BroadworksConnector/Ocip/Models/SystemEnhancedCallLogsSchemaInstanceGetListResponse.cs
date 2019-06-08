using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsSchemaInstanceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _schemaInstanceUsageTable;

    [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SchemaInstanceUsageTable {
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
