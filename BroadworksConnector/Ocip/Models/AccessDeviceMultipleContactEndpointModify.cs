using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AccessDeviceMultipleContactEndpointModify 
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "contactList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementContactList ContactList { get; set; }
    [XmlElement(ElementName = "portNumber", IsNullable = false)]
    public int PortNumber { get; set; }
 }
}
