using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointBouncedCallGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "numberOfRingsBeforeBouncingCall", IsNullable = false)]
    public int NumberOfRingsBeforeBouncingCall { get; set; }
    [XmlElement(ElementName = "enableTransfer", IsNullable = false)]
    public bool EnableTransfer { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "bounceCallWhenAgentUnavailable", IsNullable = false)]
    public bool BounceCallWhenAgentUnavailable { get; set; }
 }
}
