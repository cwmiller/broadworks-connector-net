using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetAvailableAlternateRecallUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableHuntGroupTable { get; set; }
 }
}
