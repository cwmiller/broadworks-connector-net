using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false)]
    public bool OverrideAltCallerIdForVMRetrieval { get; set; }
 }
}
