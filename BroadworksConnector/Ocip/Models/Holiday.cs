using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Holiday 
{
    [XmlElement(ElementName = "holidayName", IsNullable = false)]
    public string HolidayName { get; set; }
    [XmlElement(ElementName = "startDate", IsNullable = false)]
    public string StartDate { get; set; }
    [XmlElement(ElementName = "endDate", IsNullable = false)]
    public string EndDate { get; set; }
 }
}
