using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupsUsingCarrierTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupsUsingCarrierTable { get; set; }
 }
}
