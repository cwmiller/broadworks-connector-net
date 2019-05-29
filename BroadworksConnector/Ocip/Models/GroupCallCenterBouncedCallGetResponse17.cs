using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterBouncedCallGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    [XmlElement(ElementName = "alertCallCenterCallOnHold", IsNullable = false)]
    public bool AlertCallCenterCallOnHold { get; set; }
    [XmlElement(ElementName = "alertCallCenterCallOnHoldSeconds", IsNullable = false)]
    public int AlertCallCenterCallOnHoldSeconds { get; set; }
    [XmlElement(ElementName = "bounceCallCenterCallOnHold", IsNullable = false)]
    public bool BounceCallCenterCallOnHold { get; set; }
    [XmlElement(ElementName = "bounceCallCenterCallOnHoldSeconds", IsNullable = false)]
    public int BounceCallCenterCallOnHoldSeconds { get; set; }
 }
}
