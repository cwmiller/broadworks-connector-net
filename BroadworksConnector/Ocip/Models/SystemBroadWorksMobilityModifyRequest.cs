using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enableLocationServices", IsNullable = false)]
    public bool EnableLocationServices { get; set; }
    [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false)]
    public bool EnableMSRNLookup { get; set; }
    [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false)]
    public bool EnableMobileStateChecking { get; set; }
    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false)]
    public bool DenyCallOriginations { get; set; }
    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false)]
    public bool DenyCallTerminations { get; set; }
    [XmlElement(ElementName = "imrnTimeoutMilliseconds", IsNullable = false)]
    public int ImrnTimeoutMilliseconds { get; set; }
    [XmlElement(ElementName = "scfSignalingIPAddress", IsNullable = true)]
    public string ScfSignalingIPAddress { get; set; }
    [XmlElement(ElementName = "scfSignalingPort", IsNullable = true)]
    public int? ScfSignalingPort { get; set; }
 }
}
