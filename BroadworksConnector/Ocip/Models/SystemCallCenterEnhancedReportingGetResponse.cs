using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _archiveReports;

    [XmlElement(ElementName = "archiveReports", IsNullable = false, Namespace = "")]
    public bool ArchiveReports {
        get => _archiveReports;
        set {
            ArchiveReportsSpecified = true;
            _archiveReports = value;
        }
    }

    [XmlIgnore]
    public bool ArchiveReportsSpecified { get; set; }
    private string _reportApplicationURL;

    [XmlElement(ElementName = "reportApplicationURL", IsNullable = false, Namespace = "")]
    public string ReportApplicationURL {
        get => _reportApplicationURL;
        set {
            ReportApplicationURLSpecified = true;
            _reportApplicationURL = value;
        }
    }

    [XmlIgnore]
    public bool ReportApplicationURLSpecified { get; set; }
    private string _repositoryApplicationURL;

    [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = false, Namespace = "")]
    public string RepositoryApplicationURL {
        get => _repositoryApplicationURL;
        set {
            RepositoryApplicationURLSpecified = true;
            _repositoryApplicationURL = value;
        }
    }

    [XmlIgnore]
    public bool RepositoryApplicationURLSpecified { get; set; }
}
}
