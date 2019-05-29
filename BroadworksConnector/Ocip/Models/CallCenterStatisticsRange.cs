using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterStatisticsRange 
{
    [XmlElement(ElementName = "start", IsNullable = false)]
    public string Start { get; set; }
    [XmlElement(ElementName = "end", IsNullable = false)]
    public string End { get; set; }
 }
}
