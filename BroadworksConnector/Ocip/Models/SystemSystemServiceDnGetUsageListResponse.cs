using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemServiceDnGetUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DnUtilizationTable { get; set; }
 }
}
