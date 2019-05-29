using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false)]
    public bool OverrideAltCallerIdForVMRetrieval { get; set; }
    [XmlElement(ElementName = "stripDiversionOnVMDestinationRetrieval", IsNullable = false)]
    public bool StripDiversionOnVMDestinationRetrieval { get; set; }
 }
}
