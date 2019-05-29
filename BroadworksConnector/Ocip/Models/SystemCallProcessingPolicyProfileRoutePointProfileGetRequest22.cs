using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false)]
    public string CallProcessingPolicyProfileName { get; set; }
 }
}
