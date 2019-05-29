using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementGetEventStatusSummaryCountResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "statusCountTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable StatusCountTable { get; set; }
 }
}
