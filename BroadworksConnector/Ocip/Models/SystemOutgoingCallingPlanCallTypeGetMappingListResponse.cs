using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOutgoingCallingPlanCallTypeGetMappingListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callTypeMapping", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallTypeMapping { get; set; }
 }
}
