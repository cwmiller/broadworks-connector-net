using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DirectRouteIdentifiers 
{
    [XmlElement(ElementName = "dtgIdentity", IsNullable = false)]
    public string DtgIdentity { get; set; }
    [XmlElement(ElementName = "trunkIdentity", IsNullable = false)]
    public string TrunkIdentity { get; set; }
 }
}
