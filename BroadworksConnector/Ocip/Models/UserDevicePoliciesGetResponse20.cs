using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDevicePoliciesGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "lineMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode { get; set; }
    [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false)]
    public bool EnableDeviceFeatureSynchronization { get; set; }
    [XmlElement(ElementName = "enableDnd", IsNullable = false)]
    public bool EnableDnd { get; set; }
    [XmlElement(ElementName = "enableCallForwardingAlways", IsNullable = false)]
    public bool EnableCallForwardingAlways { get; set; }
    [XmlElement(ElementName = "enableCallForwardingBusy", IsNullable = false)]
    public bool EnableCallForwardingBusy { get; set; }
    [XmlElement(ElementName = "enableCallForwardingNoAnswer", IsNullable = false)]
    public bool EnableCallForwardingNoAnswer { get; set; }
    [XmlElement(ElementName = "enableAcd", IsNullable = false)]
    public bool EnableAcd { get; set; }
    [XmlElement(ElementName = "enableExecutive", IsNullable = false)]
    public bool EnableExecutive { get; set; }
    [XmlElement(ElementName = "enableExecutiveAssistant", IsNullable = false)]
    public bool EnableExecutiveAssistant { get; set; }
    [XmlElement(ElementName = "enableSecurityClassification", IsNullable = false)]
    public bool EnableSecurityClassification { get; set; }
    [XmlElement(ElementName = "enableCallRecording", IsNullable = false)]
    public bool EnableCallRecording { get; set; }
 }
}
