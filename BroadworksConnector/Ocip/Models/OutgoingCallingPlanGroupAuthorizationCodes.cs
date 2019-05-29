using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanGroupAuthorizationCodes 
{
    [XmlElement(ElementName = "codeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry { get; set; }
 }
}
