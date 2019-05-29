using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PublicUserIdentity 
{
    [XmlElement(ElementName = "sipURI", IsNullable = false)]
    public string SipURI { get; set; }
    [XmlElement(ElementName = "telURI", IsNullable = false)]
    public string TelURI { get; set; }
 }
}
