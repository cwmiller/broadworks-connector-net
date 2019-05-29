using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDevicePoliciesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "lineMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode { get; set; }
    [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false)]
    public bool EnableDeviceFeatureSynchronization { get; set; }
 }
}
