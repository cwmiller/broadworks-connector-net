using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "archiveReports", IsNullable = false)]
    public bool ArchiveReports { get; set; }
    [XmlElement(ElementName = "reportApplicationURL", IsNullable = false)]
    public string ReportApplicationURL { get; set; }
    [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = false)]
    public string RepositoryApplicationURL { get; set; }
 }
}
