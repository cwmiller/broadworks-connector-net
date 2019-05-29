using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantGetInstanceResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantType Type { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "extensionDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingEntries", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries { get; set; }
    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantReadMenu19 BusinessHoursMenu { get; set; }
    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantReadMenu19 AfterHoursMenu { get; set; }
    [XmlElement(ElementName = "holidayMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantReadMenu19 HolidayMenu { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
