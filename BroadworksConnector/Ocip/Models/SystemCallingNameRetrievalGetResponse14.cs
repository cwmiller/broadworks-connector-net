using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false)]
    public int QueryTimerMilliSeconds { get; set; }
    [XmlElement(ElementName = "serverNetAddress", IsNullable = false)]
    public string ServerNetAddress { get; set; }
    [XmlElement(ElementName = "serverPort", IsNullable = false)]
    public int ServerPort { get; set; }
    [XmlElement(ElementName = "serverTransportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol ServerTransportProtocol { get; set; }
 }
}
