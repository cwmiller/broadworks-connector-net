using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VirtualOnNetUserRange 
{
    [XmlElement(ElementName = "dnRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNRange DnRange { get; set; }
    [XmlElement(ElementName = "extensionRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtensionRange17 ExtensionRange { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false)]
    public string VirtualOnNetCallTypeName { get; set; }
 }
}
