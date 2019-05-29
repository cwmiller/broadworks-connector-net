using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingModifyFileServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false)]
    public string FtpHostNetAddress { get; set; }
    [XmlElement(ElementName = "passiveFTP", IsNullable = false)]
    public bool PassiveFTP { get; set; }
 }
}
