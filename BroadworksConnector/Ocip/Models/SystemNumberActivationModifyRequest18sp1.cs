using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationModifyRequest18sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "numberActivationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NumberActivationMode NumberActivationMode { get; set; }
    [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false)]
    public bool EnableEnterpriseTrunkNumberRangeActivation { get; set; }
 }
}
