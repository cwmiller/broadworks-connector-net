using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyInstanceStatisticsReportingRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _generateDailyReport;

    [XmlElement(ElementName = "generateDailyReport", IsNullable = false, Namespace = "")]
    public bool GenerateDailyReport {
        get => _generateDailyReport;
        set {
            GenerateDailyReportSpecified = true;
            _generateDailyReport = value;
        }
    }

    [XmlIgnore]
    public bool GenerateDailyReportSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes _collectionPeriodMinutes;

    [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes {
        get => _collectionPeriodMinutes;
        set {
            CollectionPeriodMinutesSpecified = true;
            _collectionPeriodMinutes = value;
        }
    }

    [XmlIgnore]
    public bool CollectionPeriodMinutesSpecified { get; set; }
    private string _reportingEmailAddress1;

    [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = true, Namespace = "")]
    public string ReportingEmailAddress1 {
        get => _reportingEmailAddress1;
        set {
            ReportingEmailAddress1Specified = true;
            _reportingEmailAddress1 = value;
        }
    }

    [XmlIgnore]
    public bool ReportingEmailAddress1Specified { get; set; }
    private string _reportingEmailAddress2;

    [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = true, Namespace = "")]
    public string ReportingEmailAddress2 {
        get => _reportingEmailAddress2;
        set {
            ReportingEmailAddress2Specified = true;
            _reportingEmailAddress2 = value;
        }
    }

    [XmlIgnore]
    public bool ReportingEmailAddress2Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource17sp1 _statisticsSource;

    [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource17sp1 StatisticsSource {
        get => _statisticsSource;
        set {
            StatisticsSourceSpecified = true;
            _statisticsSource = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsSourceSpecified { get; set; }
}
}
