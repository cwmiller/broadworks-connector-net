using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemShInterfaceParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "hssRealm", IsNullable = true)]
    public string HssRealm { get; set; }
    [XmlElement(ElementName = "requestTimeoutSeconds", IsNullable = false)]
    public int RequestTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false)]
    public int PublicIdentityRefreshDelaySeconds { get; set; }
 }
}
