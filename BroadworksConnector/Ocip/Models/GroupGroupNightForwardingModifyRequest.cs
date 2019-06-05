using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupNightForwardingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode _nightForwarding;

    [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode NightForwarding {
        get => _nightForwarding;
        set {
            NightForwardingSpecified = true;
            _nightForwarding = value;
        }
    }

    [XmlIgnore]
    public bool NightForwardingSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TimeSchedule _businessHours;

    [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours {
        get => _businessHours;
        set {
            BusinessHoursSpecified = true;
            _businessHours = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
}
}
