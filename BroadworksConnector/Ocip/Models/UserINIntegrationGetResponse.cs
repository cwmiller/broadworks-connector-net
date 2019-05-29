using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserINIntegrationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "originatingServiceKey", IsNullable = false)]
    public int OriginatingServiceKey { get; set; }
    [XmlElement(ElementName = "terminatingServiceKey", IsNullable = false)]
    public int TerminatingServiceKey { get; set; }
 }
}
