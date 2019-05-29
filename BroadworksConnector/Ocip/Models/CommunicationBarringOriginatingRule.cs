using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringOriginatingRule 
{
    [XmlElement(ElementName = "criteria", IsNullable = false)]
    public string Criteria { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingAction Action { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = true)]
    public string TreatmentId { get; set; }
    [XmlElement(ElementName = "transferNumber", IsNullable = true)]
    public string TransferNumber { get; set; }
    [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true)]
    public int? CallTimeoutSeconds { get; set; }
 }
}
