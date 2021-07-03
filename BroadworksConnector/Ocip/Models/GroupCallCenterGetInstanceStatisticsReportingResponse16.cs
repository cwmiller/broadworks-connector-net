using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics reporting settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6137""}]")]
    public class GroupCallCenterGetInstanceStatisticsReportingResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _generateDailyReport;

        [XmlElement(ElementName = "generateDailyReport", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6137")]
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
        protected bool GenerateDailyReportSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes _collectionPeriodMinutes;

        [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6137")]
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
        protected bool CollectionPeriodMinutesSpecified { get; set; }

        private string _reportingEmailAddress1;

        [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6137")]
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
        protected bool ReportingEmailAddress1Specified { get; set; }

        private string _reportingEmailAddress2;

        [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6137")]
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
        protected bool ReportingEmailAddress2Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource _statisticsSource;

        [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6137")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource StatisticsSource
        {
            get => _statisticsSource;
            set
            {
                StatisticsSourceSpecified = true;
                _statisticsSource = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsSourceSpecified { get; set; }

    }
}
