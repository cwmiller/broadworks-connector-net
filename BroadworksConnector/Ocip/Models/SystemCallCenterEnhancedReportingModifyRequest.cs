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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6076""}]")]
    public class SystemCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _archiveReports;

        [XmlElement(ElementName = "archiveReports", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6076")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:6076")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:6076")]
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
