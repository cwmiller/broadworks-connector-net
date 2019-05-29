using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = true)]
    public string BusinessHours { get; set; }
    [XmlElement(ElementName = "holidayScheduleName", IsNullable = true)]
    public string HolidayScheduleName { get; set; }
    [XmlElement(ElementName = "extensionDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope { get; set; }
    [XmlElement(ElementName = "nameDialingEntries", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries { get; set; }
    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu BusinessHoursMenu { get; set; }
    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu AfterHoursMenu { get; set; }
 }
}
