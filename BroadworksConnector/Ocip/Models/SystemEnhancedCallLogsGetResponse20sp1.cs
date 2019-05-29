using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsGetResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isSendEnabled", IsNullable = false)]
    public bool IsSendEnabled { get; set; }
    [XmlElement(ElementName = "server1NetAddress", IsNullable = false)]
    public string Server1NetAddress { get; set; }
    [XmlElement(ElementName = "server1SendPort", IsNullable = false)]
    public int Server1SendPort { get; set; }
    [XmlElement(ElementName = "server1RetrievePort", IsNullable = false)]
    public int Server1RetrievePort { get; set; }
    [XmlElement(ElementName = "server2NetAddress", IsNullable = false)]
    public string Server2NetAddress { get; set; }
    [XmlElement(ElementName = "server2SendPort", IsNullable = false)]
    public int Server2SendPort { get; set; }
    [XmlElement(ElementName = "server2RetrievePort", IsNullable = false)]
    public int Server2RetrievePort { get; set; }
    [XmlElement(ElementName = "sharedSecret", IsNullable = false)]
    public string SharedSecret { get; set; }
    [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false)]
    public int RetransmissionDelayMilliSeconds { get; set; }
    [XmlElement(ElementName = "maxTransmissions", IsNullable = false)]
    public int MaxTransmissions { get; set; }
    [XmlElement(ElementName = "soapTimeoutSeconds", IsNullable = false)]
    public int SoapTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "useDBS", IsNullable = false)]
    public bool UseDBS { get; set; }
    [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false)]
    public int MaxNonPagedResponseSize { get; set; }
    [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = false)]
    public string EclQueryApplicationURL { get; set; }
    [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = false)]
    public string EclQueryDataRepositoryURL { get; set; }
 }
}
