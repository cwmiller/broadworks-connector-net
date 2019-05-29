using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Contact 
{
    [XmlElement(ElementName = "contactName", IsNullable = true)]
    public string ContactName { get; set; }
    [XmlElement(ElementName = "contactNumber", IsNullable = true)]
    public string ContactNumber { get; set; }
    [XmlElement(ElementName = "contactEmail", IsNullable = true)]
    public string ContactEmail { get; set; }
 }
}
