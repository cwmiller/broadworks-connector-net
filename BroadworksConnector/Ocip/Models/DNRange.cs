using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DNRange 
{
    [XmlElement(ElementName = "minPhoneNumber", IsNullable = false)]
    public string MinPhoneNumber { get; set; }
    [XmlElement(ElementName = "maxPhoneNumber", IsNullable = false)]
    public string MaxPhoneNumber { get; set; }
 }
}
