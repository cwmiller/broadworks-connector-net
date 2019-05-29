using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationEndpointLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userEndpointKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserEndpointKey> UserEndpointKey { get; set; }
 }
}
