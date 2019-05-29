using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExchangeIntegrationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false)]
    public bool EnableExchangeIntegration { get; set; }
    [XmlElement(ElementName = "exchangeURL", IsNullable = true)]
    public string ExchangeURL { get; set; }
    [XmlElement(ElementName = "exchangeCredentials", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ExchangeUserNamePassword ExchangeCredentials { get; set; }
 }
}
