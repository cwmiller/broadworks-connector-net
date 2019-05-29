using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateBridgeMaximumParticipants 
{
    [XmlElement(ElementName = "unlimited", IsNullable = false)]
    public bool Unlimited { get; set; }
    [XmlElement(ElementName = "quantity", IsNullable = false)]
    public int Quantity { get; set; }
 }
}
