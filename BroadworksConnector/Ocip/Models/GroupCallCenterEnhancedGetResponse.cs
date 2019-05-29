using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false)]
    public bool OverrideAgentWrapUpTime { get; set; }
    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false)]
    public int WrapUpSeconds { get; set; }
 }
}
