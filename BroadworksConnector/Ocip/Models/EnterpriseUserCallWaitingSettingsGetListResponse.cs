using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseUserCallWaitingSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userCallWaitingTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserCallWaitingTable { get; set; }
 }
}
