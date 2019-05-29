using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneCallingRestrictionsZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "zoneTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ZoneTable { get; set; }
 }
}
