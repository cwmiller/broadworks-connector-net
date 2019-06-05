using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetListRequest17sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ScheduleType _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleType ScheduleType {
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
