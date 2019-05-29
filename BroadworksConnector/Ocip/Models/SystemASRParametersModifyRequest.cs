using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemASRParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "maxTransmissions", IsNullable = false)]
    public int MaxTransmissions { get; set; }
    [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false)]
    public int RetransmissionDelayMilliSeconds { get; set; }
    [XmlElement(ElementName = "listeningPort", IsNullable = false)]
    public int ListeningPort { get; set; }
    [XmlElement(ElementName = "sourceAddress", IsNullable = true)]
    public string SourceAddress { get; set; }
 }
}
