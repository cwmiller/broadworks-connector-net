using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReceptionistContactUserAndNote 
{
    [XmlElement(ElementName = "contactUserId", IsNullable = false)]
    public string ContactUserId { get; set; }
    [XmlElement(ElementName = "vonUser", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VirtualOnNetUserKey VonUser { get; set; }
    [XmlElement(ElementName = "note", IsNullable = true)]
    public string Note { get; set; }
 }
}
