using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanRedirectedGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useCustomSettings", IsNullable = false)]
    public bool UseCustomSettings { get; set; }
    [XmlElement(ElementName = "userPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanRedirectedPermissions UserPermissions { get; set; }
 }
}
