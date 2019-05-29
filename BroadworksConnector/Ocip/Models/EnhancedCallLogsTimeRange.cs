using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsTimeRange 
{
    [XmlElement(ElementName = "startDateTime", IsNullable = false)]
    public string StartDateTime { get; set; }
    [XmlElement(ElementName = "endDateTime", IsNullable = false)]
    public string EndDateTime { get; set; }
 }
}
