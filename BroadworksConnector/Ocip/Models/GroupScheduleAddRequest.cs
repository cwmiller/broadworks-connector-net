using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private string _scheduleName;

    [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
    public string ScheduleName {
        get => _scheduleName;
        set {
            ScheduleNameSpecified = true;
            _scheduleName = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ScheduleType _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ScheduleType ScheduleType {
        get => _scheduleType;
        set {
            ScheduleTypeSpecified = true;
            _scheduleType = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleTypeSpecified { get; set; }
}
}