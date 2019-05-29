using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupNightForwardingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "nightForwarding", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding { get; set; }
    [XmlElement(ElementName = "groupNightForwarding", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode GroupNightForwarding { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
 }
}
