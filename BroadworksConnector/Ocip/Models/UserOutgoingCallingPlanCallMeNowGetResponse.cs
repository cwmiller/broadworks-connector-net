using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanCallMeNowGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useCustomSettings", IsNullable = false)]
    public bool UseCustomSettings { get; set; }
    [XmlElement(ElementName = "userPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions UserPermissions { get; set; }
 }
}
