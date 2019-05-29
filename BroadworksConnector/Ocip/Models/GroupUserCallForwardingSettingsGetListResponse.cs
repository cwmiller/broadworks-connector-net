using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserCallForwardingSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userCallForwardingTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserCallForwardingTable { get; set; }
 }
}
