using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportDNISSelectionRead 
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "deleted", IsNullable = false)]
    public bool Deleted { get; set; }
    [XmlElement(ElementName = "allDNIS", IsNullable = false)]
    public bool AllDNIS { get; set; }
    [XmlElement(ElementName = "currentName", IsNullable = false)]
    public List<string> CurrentName { get; set; }
    [XmlElement(ElementName = "pastName", IsNullable = false)]
    public List<string> PastName { get; set; }
 }
}
