using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkSynchingServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "preferredNetworkServerNetAddress", IsNullable = false)]
    public string PreferredNetworkServerNetAddress { get; set; }
    [XmlElement(ElementName = "networkSynchingServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable NetworkSynchingServerTable { get; set; }
 }
}
