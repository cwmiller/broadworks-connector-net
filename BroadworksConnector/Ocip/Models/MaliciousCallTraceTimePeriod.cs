using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MaliciousCallTraceTimePeriod 
{
    [XmlElement(ElementName = "startDateTime", IsNullable = false)]
    public string StartDateTime { get; set; }
    [XmlElement(ElementName = "stopDateTime", IsNullable = false)]
    public string StopDateTime { get; set; }
 }
}
