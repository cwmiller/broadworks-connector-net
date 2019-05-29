using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemASRParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxTransmissions", IsNullable = false)]
    public int MaxTransmissions { get; set; }
    [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false)]
    public int RetransmissionDelayMilliSeconds { get; set; }
    [XmlElement(ElementName = "listeningPort", IsNullable = false)]
    public int ListeningPort { get; set; }
 }
}
