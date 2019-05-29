using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringOriginatingRule15sp2 
{
    [XmlElement(ElementName = "criteria", IsNullable = false)]
    public string Criteria { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 Action { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = true)]
    public string TreatmentId { get; set; }
    [XmlElement(ElementName = "transferNumber", IsNullable = true)]
    public string TransferNumber { get; set; }
 }
}
