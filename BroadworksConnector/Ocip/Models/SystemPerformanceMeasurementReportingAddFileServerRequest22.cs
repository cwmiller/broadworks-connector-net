using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingAddFileServerRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "repositoryUrl", IsNullable = false)]
    public string RepositoryUrl { get; set; }
    [XmlElement(ElementName = "ftpUserId", IsNullable = false)]
    public string FtpUserId { get; set; }
    [XmlElement(ElementName = "ftpUserPassword", IsNullable = false)]
    public string FtpUserPassword { get; set; }
    [XmlElement(ElementName = "passiveFTP", IsNullable = false)]
    public bool PassiveFTP { get; set; }
 }
}
