using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderExternalCustomRingbackModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "prefixDigits", IsNullable = true)]
    public string PrefixDigits { get; set; }
    [XmlElement(ElementName = "serverNetAddress", IsNullable = true)]
    public string ServerNetAddress { get; set; }
    [XmlElement(ElementName = "serverPort", IsNullable = true)]
    public int? ServerPort { get; set; }
    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false)]
    public int TimeoutSeconds { get; set; }
 }
}
