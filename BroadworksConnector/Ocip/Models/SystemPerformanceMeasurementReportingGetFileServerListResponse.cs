using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingGetFileServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "fileServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable FileServerTable { get; set; }
 }
}
