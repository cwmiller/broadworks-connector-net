using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingModifyFileServerRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "repositoryUrl", IsNullable = false)]
    public string RepositoryUrl { get; set; }
    [XmlElement(ElementName = "passiveFTP", IsNullable = false)]
    public bool PassiveFTP { get; set; }
 }
}
