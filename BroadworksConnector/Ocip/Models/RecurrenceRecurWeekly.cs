using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurWeekly 
{
    [XmlElement(ElementName = "recurInterval", IsNullable = false)]
    public int RecurInterval { get; set; }
    [XmlElement(ElementName = "sunday", IsNullable = false)]
    public bool Sunday { get; set; }
    [XmlElement(ElementName = "monday", IsNullable = false)]
    public bool Monday { get; set; }
    [XmlElement(ElementName = "tuesday", IsNullable = false)]
    public bool Tuesday { get; set; }
    [XmlElement(ElementName = "wednesday", IsNullable = false)]
    public bool Wednesday { get; set; }
    [XmlElement(ElementName = "thursday", IsNullable = false)]
    public bool Thursday { get; set; }
    [XmlElement(ElementName = "friday", IsNullable = false)]
    public bool Friday { get; set; }
    [XmlElement(ElementName = "saturday", IsNullable = false)]
    public bool Saturday { get; set; }
 }
}
