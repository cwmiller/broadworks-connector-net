using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterAgentDetailsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isCallCenterBasicAssigned", IsNullable = false)]
    public bool IsCallCenterBasicAssigned { get; set; }
    [XmlElement(ElementName = "isCallCenterStandardAssigned", IsNullable = false)]
    public bool IsCallCenterStandardAssigned { get; set; }
    [XmlElement(ElementName = "isCallCenterPremiumAssigned", IsNullable = false)]
    public bool IsCallCenterPremiumAssigned { get; set; }
 }
}
