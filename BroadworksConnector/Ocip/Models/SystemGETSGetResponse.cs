using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
    [XmlElement(ElementName = "enableRequireResourcePriority", IsNullable = false)]
    public bool EnableRequireResourcePriority { get; set; }
    [XmlElement(ElementName = "sendAccessResourcePriority", IsNullable = false)]
    public bool SendAccessResourcePriority { get; set; }
    [XmlElement(ElementName = "callIdentifierMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GETSCallIdentifierMode CallIdentifierMode { get; set; }
    [XmlElement(ElementName = "defaultPriorityAVP", IsNullable = false)]
    public int DefaultPriorityAVP { get; set; }
    [XmlElement(ElementName = "signalingDSCP", IsNullable = false)]
    public int SignalingDSCP { get; set; }
    [XmlElement(ElementName = "defaultRValue", IsNullable = false)]
    public string DefaultRValue { get; set; }
    [XmlElement(ElementName = "bypassRoRelease", IsNullable = false)]
    public bool BypassRoRelease { get; set; }
 }
}
