using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeScheduleAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "timeScheduleName", IsNullable = false)]
    public string TimeScheduleName { get; set; }
    [XmlElement(ElementName = "timeInterval01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval01 { get; set; }
    [XmlElement(ElementName = "timeInterval02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval02 { get; set; }
    [XmlElement(ElementName = "timeInterval03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval03 { get; set; }
    [XmlElement(ElementName = "timeInterval04", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval04 { get; set; }
    [XmlElement(ElementName = "timeInterval05", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval05 { get; set; }
    [XmlElement(ElementName = "timeInterval06", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval06 { get; set; }
    [XmlElement(ElementName = "timeInterval07", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval07 { get; set; }
    [XmlElement(ElementName = "timeInterval08", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval08 { get; set; }
    [XmlElement(ElementName = "timeInterval09", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval09 { get; set; }
    [XmlElement(ElementName = "timeInterval10", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval10 { get; set; }
    [XmlElement(ElementName = "timeInterval11", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval11 { get; set; }
    [XmlElement(ElementName = "timeInterval12", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval12 { get; set; }
    [XmlElement(ElementName = "timeInterval13", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval13 { get; set; }
    [XmlElement(ElementName = "timeInterval14", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval14 { get; set; }
    [XmlElement(ElementName = "timeInterval15", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval15 { get; set; }
    [XmlElement(ElementName = "timeInterval16", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval16 { get; set; }
    [XmlElement(ElementName = "timeInterval17", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval17 { get; set; }
    [XmlElement(ElementName = "timeInterval18", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval18 { get; set; }
    [XmlElement(ElementName = "timeInterval19", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval19 { get; set; }
    [XmlElement(ElementName = "timeInterval20", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeInterval TimeInterval20 { get; set; }
 }
}
