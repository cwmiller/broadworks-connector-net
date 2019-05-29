using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobileManagerGetHomeZoneListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "homeZonesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable HomeZonesTable { get; set; }
 }
}
