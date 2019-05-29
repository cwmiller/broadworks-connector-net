using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementContactList22 
{
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SIPContactInfo> Contact { get; set; }
 }
}
