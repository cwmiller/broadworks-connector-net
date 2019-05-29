using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AccessDeviceKey> AccessDevice { get; set; }
 }
}
