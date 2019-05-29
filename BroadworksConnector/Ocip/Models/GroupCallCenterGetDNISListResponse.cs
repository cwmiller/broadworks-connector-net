using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "displayDNISNumber", IsNullable = false)]
    public bool DisplayDNISNumber { get; set; }
    [XmlElement(ElementName = "displayDNISName", IsNullable = false)]
    public bool DisplayDNISName { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority1to0", IsNullable = false)]
    public bool PromoteCallsFromPriority1to0 { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority2to1", IsNullable = false)]
    public bool PromoteCallsFromPriority2to1 { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority3to2", IsNullable = false)]
    public bool PromoteCallsFromPriority3to2 { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority1to0Seconds", IsNullable = false)]
    public int PromoteCallsFromPriority1to0Seconds { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority2to1Seconds", IsNullable = false)]
    public int PromoteCallsFromPriority2to1Seconds { get; set; }
    [XmlElement(ElementName = "promoteCallsFromPriority3to2Seconds", IsNullable = false)]
    public int PromoteCallsFromPriority3to2Seconds { get; set; }
    [XmlElement(ElementName = "dnisTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DnisTable { get; set; }
 }
}
