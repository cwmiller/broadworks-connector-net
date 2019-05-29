using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEmergencyCallDDoSProtectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
    [XmlElement(ElementName = "sampleIntervalSeconds", IsNullable = false)]
    public int SampleIntervalSeconds { get; set; }
    [XmlElement(ElementName = "protectionRate", IsNullable = true)]
    public int? ProtectionRate { get; set; }
    [XmlElement(ElementName = "protectionAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ProtectionAction ProtectionAction { get; set; }
 }
}
