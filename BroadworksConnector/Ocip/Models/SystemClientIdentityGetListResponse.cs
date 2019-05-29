using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClientIdentityGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "clientIdentityTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ClientIdentityTable { get; set; }
 }
}
