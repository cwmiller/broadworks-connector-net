using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterGetInstanceStatisticsReportingRequest17sp1.
    /// Contains Call Center statistics reporting settings.
    /// <see cref="GroupCallCenterGetInstanceStatisticsReportingRequest17sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4739""}]")]
    public class GroupCallCenterGetInstanceStatisticsReportingResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _generateDailyReport;

        [XmlElement(ElementName = "generateDailyReport", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4739")]
        public bool GenerateDailyReport
        {
            get => _generateDailyReport;
            set
            {
                GenerateDailyReportSpecified = true;
                _generateDailyReport = value;
            }
        }

        [XmlIgnore]
        public bool GenerateDailyReportSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes _collectionPeriodMinutes;

        [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4739")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes
        {
            get => _collectionPeriodMinutes;
            set
            {
                CollectionPeriodMinutesSpecified = true;
                _collectionPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        public bool CollectionPeriodMinutesSpecified { get; set; }

        private string _reportingEmailAddress1;

        [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4739")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportingEmailAddress1
        {
            get => _reportingEmailAddress1;
            set
            {
                ReportingEmailAddress1Specified = true;
                _reportingEmailAddress1 = value;
            }
        }

        [XmlIgnore]
        public bool ReportingEmailAddress1Specified { get; set; }

        private string _reportingEmailAddress2;

        [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4739")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportingEmailAddress2
        {
            get => _reportingEmailAddress2;
            set
            {
                ReportingEmailAddress2Specified = true;
                _reportingEmailAddress2 = value;
            }
        }

        [XmlIgnore]
        public bool ReportingEmailAddress2Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource17sp1 _statisticsSource;

        [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4739")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource17sp1 StatisticsSource
        {
            get => _statisticsSource;
            set
            {
                StatisticsSourceSpecified = true;
                _statisticsSource = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsSourceSpecified { get; set; }

    }
}
