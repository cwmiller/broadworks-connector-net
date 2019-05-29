using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "archiveReports", IsNullable = false)]
    public bool ArchiveReports { get; set; }
    [XmlElement(ElementName = "reportApplicationURL", IsNullable = true)]
    public string ReportApplicationURL { get; set; }
    [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = true)]
    public string RepositoryApplicationURL { get; set; }
 }
}
