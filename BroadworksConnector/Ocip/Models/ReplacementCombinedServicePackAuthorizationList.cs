using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedServicePackAuthorizationList 
{
    [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedServicePackAuthorization> ServicePackAuthorization { get; set; }
 }
}
