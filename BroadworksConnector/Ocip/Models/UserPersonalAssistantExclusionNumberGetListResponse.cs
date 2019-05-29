using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "exclusionNumberTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ExclusionNumberTable { get; set; }
 }
}
