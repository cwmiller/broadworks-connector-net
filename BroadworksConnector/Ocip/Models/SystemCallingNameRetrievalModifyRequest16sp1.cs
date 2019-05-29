using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalModifyRequest16sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false)]
    public bool TriggerCNAMQueriesForAllNetworkCalls { get; set; }
    [XmlElement(ElementName = "triggerCNAMQueriesForGroupAndEnterpriseCalls", IsNullable = false)]
    public bool TriggerCNAMQueriesForGroupAndEnterpriseCalls { get; set; }
    [XmlElement(ElementName = "queryProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol QueryProtocol { get; set; }
    [XmlElement(ElementName = "queryTimeoutMilliseconds", IsNullable = false)]
    public int QueryTimeoutMilliseconds { get; set; }
    [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = true)]
    public string SipExternalDatabaseNetAddress { get; set; }
    [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = true)]
    public int? SipExternalDatabasePort { get; set; }
    [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol SipExternalDatabaseTransport { get; set; }
    [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = true)]
    public string SoapExternalDatabaseNetAddress { get; set; }
    [XmlElement(ElementName = "soapSupportsDNSSRV", IsNullable = false)]
    public bool SoapSupportsDNSSRV { get; set; }
    [XmlElement(ElementName = "callingNameSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity CallingNameSource { get; set; }
 }
}
