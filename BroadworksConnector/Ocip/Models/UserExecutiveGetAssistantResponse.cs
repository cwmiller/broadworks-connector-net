using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetAssistantResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allowOptInOut", IsNullable = false)]
    public bool AllowOptInOut { get; set; }
    [XmlElement(ElementName = "assistantUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AssistantUserTable { get; set; }
 }
}
