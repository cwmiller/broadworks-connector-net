using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServicePolicyProfileKey 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "category", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServicePolicyProfileCategory Category { get; set; }
 }
}
