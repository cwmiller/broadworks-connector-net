using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsCallAuthorizationCodeFilter 
{
    [XmlElement(ElementName = "callsWithCodes", IsNullable = false)]
    public bool CallsWithCodes { get; set; }
    [XmlElement(ElementName = "authorizationCode", IsNullable = false)]
    public string AuthorizationCode { get; set; }
 }
}
