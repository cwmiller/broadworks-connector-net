using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SIPContactInfo 
{
    [XmlElement(ElementName = "sipContact", IsNullable = false)]
    public string SipContact { get; set; }
    [XmlElement(ElementName = "pathHeader", IsNullable = false)]
    public string PathHeader { get; set; }
 }
}
