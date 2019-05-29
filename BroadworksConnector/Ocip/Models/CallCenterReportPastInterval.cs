using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportPastInterval 
{
    [XmlElement(ElementName = "number", IsNullable = false)]
    public int Number { get; set; }
    [XmlElement(ElementName = "timeUnit", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit TimeUnit { get; set; }
 }
}
