using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupNightForwardingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

    [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding {
        get => _nightForwarding;
        set {
            NightForwardingSpecified = true;
            _nightForwarding = value;
        }
    }

    [XmlIgnore]
    public bool NightForwardingSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode _groupNightForwarding;

    [XmlElement(ElementName = "groupNightForwarding", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode GroupNightForwarding {
        get => _groupNightForwarding;
        set {
            GroupNightForwardingSpecified = true;
            _groupNightForwarding = value;
        }
    }

    [XmlIgnore]
    public bool GroupNightForwardingSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TimeSchedule _businessHours;

    [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
}
}
