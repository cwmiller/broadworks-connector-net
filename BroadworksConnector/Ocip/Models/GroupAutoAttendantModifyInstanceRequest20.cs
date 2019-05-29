using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantModifyInstanceRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "firstDigitTimeoutSeconds", IsNullable = false)]
    public int FirstDigitTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "extensionDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingEntries", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries { get; set; }
    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu20 BusinessHoursMenu { get; set; }
    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu20 AfterHoursMenu { get; set; }
    [XmlElement(ElementName = "holidayMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu20 HolidayMenu { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
