using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false)]
    public int QueryTimerMilliSeconds { get; set; }
    [XmlElement(ElementName = "serverNetAddress", IsNullable = true)]
    public string ServerNetAddress { get; set; }
    [XmlElement(ElementName = "serverPort", IsNullable = true)]
    public int? ServerPort { get; set; }
    [XmlElement(ElementName = "serverTransportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol ServerTransportProtocol { get; set; }
 }
}
