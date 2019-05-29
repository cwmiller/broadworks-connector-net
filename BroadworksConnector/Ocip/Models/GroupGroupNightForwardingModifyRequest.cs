using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupNightForwardingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "nightForwarding", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode NightForwarding { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true)]
    public string ForwardToPhoneNumber { get; set; }
 }
}
