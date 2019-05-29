using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "useDomain", IsNullable = false)]
    public bool UseDomain { get; set; }
 }
}
