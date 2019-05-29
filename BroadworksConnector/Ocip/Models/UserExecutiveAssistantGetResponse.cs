using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveAssistantGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableDivert", IsNullable = false)]
    public bool EnableDivert { get; set; }
    [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = false)]
    public string DivertToPhoneNumber { get; set; }
    [XmlElement(ElementName = "executiveTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ExecutiveTable { get; set; }
 }
}
