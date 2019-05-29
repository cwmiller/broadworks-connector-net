using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class HourMinute 
{
    [XmlElement(ElementName = "hour", IsNullable = false)]
    public int Hour { get; set; }
    [XmlElement(ElementName = "minute", IsNullable = false)]
    public int Minute { get; set; }
 }
}
