using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemVoicePortalsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemVoicePortalsTable { get; set; }
 }
}
