using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetAvailablePortalListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "portalTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PortalTable { get; set; }
 }
}
