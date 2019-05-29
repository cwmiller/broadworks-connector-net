using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderExternalCustomRingbackGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "prefixDigits", IsNullable = false)]
    public string PrefixDigits { get; set; }
    [XmlElement(ElementName = "serverNetAddress", IsNullable = false)]
    public string ServerNetAddress { get; set; }
    [XmlElement(ElementName = "serverPort", IsNullable = false)]
    public int ServerPort { get; set; }
    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false)]
    public int TimeoutSeconds { get; set; }
 }
}
