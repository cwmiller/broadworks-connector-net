using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHolidayScheduleModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "holidayScheduleName", IsNullable = false)]
    public string HolidayScheduleName { get; set; }
    [XmlElement(ElementName = "newHolidayScheduleName", IsNullable = false)]
    public string NewHolidayScheduleName { get; set; }
    [XmlElement(ElementName = "holiday01", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday01 { get; set; }
    [XmlElement(ElementName = "holiday02", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday02 { get; set; }
    [XmlElement(ElementName = "holiday03", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday03 { get; set; }
    [XmlElement(ElementName = "holiday04", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday04 { get; set; }
    [XmlElement(ElementName = "holiday05", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday05 { get; set; }
    [XmlElement(ElementName = "holiday06", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday06 { get; set; }
    [XmlElement(ElementName = "holiday07", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday07 { get; set; }
    [XmlElement(ElementName = "holiday08", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday08 { get; set; }
    [XmlElement(ElementName = "holiday09", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday09 { get; set; }
    [XmlElement(ElementName = "holiday10", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday10 { get; set; }
    [XmlElement(ElementName = "holiday11", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday11 { get; set; }
    [XmlElement(ElementName = "holiday12", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday12 { get; set; }
    [XmlElement(ElementName = "holiday13", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday13 { get; set; }
    [XmlElement(ElementName = "holiday14", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday14 { get; set; }
    [XmlElement(ElementName = "holiday15", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday15 { get; set; }
    [XmlElement(ElementName = "holiday16", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday16 { get; set; }
    [XmlElement(ElementName = "holiday17", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday17 { get; set; }
    [XmlElement(ElementName = "holiday18", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday18 { get; set; }
    [XmlElement(ElementName = "holiday19", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday19 { get; set; }
    [XmlElement(ElementName = "holiday20", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Holiday Holiday20 { get; set; }
 }
}
