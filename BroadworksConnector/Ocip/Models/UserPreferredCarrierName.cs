using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPreferredCarrierName 
{
    [XmlElement(ElementName = "useGroupPreferredCarrier", IsNullable = false)]
    public bool UseGroupPreferredCarrier { get; set; }
    [XmlElement(ElementName = "carrier", IsNullable = false)]
    public string Carrier { get; set; }
 }
}
