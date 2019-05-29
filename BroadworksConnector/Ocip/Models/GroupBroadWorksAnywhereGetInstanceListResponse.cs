using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksAnywhereGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "broadWorksAnywhereTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable BroadWorksAnywhereTable { get; set; }
 }
}
