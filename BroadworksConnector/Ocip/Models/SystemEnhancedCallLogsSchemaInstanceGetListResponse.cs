using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsSchemaInstanceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SchemaInstanceUsageTable { get; set; }
 }
}
