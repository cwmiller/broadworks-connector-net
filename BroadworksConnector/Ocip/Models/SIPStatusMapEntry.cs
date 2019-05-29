using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SIPStatusMapEntry 
{
    [XmlElement(ElementName = "sipStatusCode", IsNullable = false)]
    public int SipStatusCode { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
 }
}
