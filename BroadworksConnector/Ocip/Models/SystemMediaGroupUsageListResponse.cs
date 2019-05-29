using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGroupUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "usageTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UsageTable { get; set; }
 }
}
