using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsAccountAuthorizationCodeFilter 
{
    [XmlElement(ElementName = "callsWithCodes", IsNullable = false)]
    public bool CallsWithCodes { get; set; }
    [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false)]
    public string AccountAuthorizationCode { get; set; }
 }
}
