using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemASRParametersGetResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxTransmissions", IsNullable = false)]
    public int MaxTransmissions { get; set; }
    [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false)]
    public int RetransmissionDelayMilliSeconds { get; set; }
    [XmlElement(ElementName = "listeningPort", IsNullable = false)]
    public int ListeningPort { get; set; }
    [XmlElement(ElementName = "enableCustomMessageControl", IsNullable = false)]
    public bool EnableCustomMessageControl { get; set; }
    [XmlElement(ElementName = "customNumberOfUsersPerMessage", IsNullable = false)]
    public int CustomNumberOfUsersPerMessage { get; set; }
    [XmlElement(ElementName = "customMessageIntervalMilliseconds", IsNullable = false)]
    public int CustomMessageIntervalMilliseconds { get; set; }
 }
}
