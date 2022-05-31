using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system settings for call center enhanced reporting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6080""}]")]
    public class SystemCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _archiveReports;

        [XmlElement(ElementName = "archiveReports", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6080")]
        public bool ArchiveReports
        {
            get => _archiveReports;
            set
            {
                ArchiveReportsSpecified = true;
                _archiveReports = value;
            }
        }

        [XmlIgnore]
        protected bool ArchiveReportsSpecified { get; set; }

        protected string _reportApplicationURL;

        [XmlElement(ElementName = "reportApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6080")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ReportApplicationURL
        {
            get => _reportApplicationURL;
            set
            {
                ReportApplicationURLSpecified = true;
                _reportApplicationURL = value;
            }
        }

        [XmlIgnore]
        protected bool ReportApplicationURLSpecified { get; set; }

        protected string _repositoryApplicationURL;

        [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6080")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryApplicationURL
        {
            get => _repositoryApplicationURL;
            set
            {
                RepositoryApplicationURLSpecified = true;
                _repositoryApplicationURL = value;
            }
        }

        [XmlIgnore]
        protected bool RepositoryApplicationURLSpecified { get; set; }

    }
}
