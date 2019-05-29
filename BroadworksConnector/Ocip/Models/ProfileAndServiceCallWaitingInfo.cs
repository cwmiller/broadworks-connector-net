using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCallWaitingInfo 
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false)]
    public bool DisableCallingLineIdDelivery { get; set; }
 }
}
