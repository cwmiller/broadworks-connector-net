using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExchangeIntegrationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false)]
    public bool EnableExchangeIntegration { get; set; }
    [XmlElement(ElementName = "exchangeURL", IsNullable = false)]
    public string ExchangeURL { get; set; }
    [XmlElement(ElementName = "exchangeUserName", IsNullable = false)]
    public string ExchangeUserName { get; set; }
 }
}
