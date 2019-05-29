using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "assignedSubscriberType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> AssignedSubscriberType { get; set; }
 }
}
