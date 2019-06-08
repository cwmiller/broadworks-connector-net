using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AttendantConsoleDisplayColumn{
    [XmlEnum(Name = "Action")]
    Action,
    [XmlEnum(Name = "Department")]
    Department,
    [XmlEnum(Name = "Email")]
    Email,
    [XmlEnum(Name = "Extension")]
    Extension,
    [XmlEnum(Name = "Mobile")]
    Mobile,
    [XmlEnum(Name = "Name")]
    Name,
    [XmlEnum(Name = "Phone Number")]
    PhoneNumber,
    [XmlEnum(Name = "Pager")]
    Pager,
    [XmlEnum(Name = "Status")]
    Status,
    [XmlEnum(Name = "Title")]
    Title,
 }
}
