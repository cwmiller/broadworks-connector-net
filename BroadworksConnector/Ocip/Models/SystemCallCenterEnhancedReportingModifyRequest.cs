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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6118""}]")]
    public class SystemCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _archiveReports;

        [XmlElement(ElementName = "archiveReports", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6118")]
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
        public bool ArchiveReportsSpecified { get; set; }

        private string _reportApplicationURL;

        [XmlElement(ElementName = "reportApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6118")]
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
        public bool ReportApplicationURLSpecified { get; set; }

        private string _repositoryApplicationURL;

        [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6118")]
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
        public bool RepositoryApplicationURLSpecified { get; set; }

    }
}
