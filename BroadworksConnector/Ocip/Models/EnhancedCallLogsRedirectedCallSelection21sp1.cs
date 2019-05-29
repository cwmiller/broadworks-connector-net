using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsRedirectedCallSelection21sp1 
{
    [XmlElement(ElementName = "redirectedCall", IsNullable = false)]
    public bool RedirectedCall { get; set; }
    [XmlElement(ElementName = "redirectType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceInvocationDisposition21sp1> RedirectType { get; set; }
 }
}
