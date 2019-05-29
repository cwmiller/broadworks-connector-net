using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreferredCarrierName 
{
    [XmlElement(ElementName = "useServiceProviderPreferredCarrier", IsNullable = false)]
    public bool UseServiceProviderPreferredCarrier { get; set; }
    [XmlElement(ElementName = "carrier", IsNullable = false)]
    public string Carrier { get; set; }
 }
}
