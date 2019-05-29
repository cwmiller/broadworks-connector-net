using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberActivationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NumberActivationMode NumberActivationMode { get; set; }
    [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false)]
    public bool EnableEnterpriseTrunkNumberRangeActivation { get; set; }
 }
}
