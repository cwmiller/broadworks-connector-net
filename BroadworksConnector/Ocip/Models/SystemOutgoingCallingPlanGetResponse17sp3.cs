using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOutgoingCallingPlanGetResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "directTransferScreening", IsNullable = false)]
    public bool DirectTransferScreening { get; set; }
    [XmlElement(ElementName = "enableEnhancedTollCallTyping", IsNullable = false)]
    public bool EnableEnhancedTollCallTyping { get; set; }
 }
}
