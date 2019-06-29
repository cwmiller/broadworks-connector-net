using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingGetRequest.
    /// <see cref="SystemCallCenterEnhancedReportingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6100""}]")]
    public class SystemCallCenterEnhancedReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _archiveReports;

        [XmlElement(ElementName = "archiveReports", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6100")]
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

        private string _reportApplicationURL;

        [XmlElement(ElementName = "reportApplicationURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6100")]
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

        private string _repositoryApplicationURL;

        [XmlElement(ElementName = "repositoryApplicationURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6100")]
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
