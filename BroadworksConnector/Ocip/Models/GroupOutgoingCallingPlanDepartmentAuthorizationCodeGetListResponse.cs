using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "codeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry { get; set; }
 }
}
