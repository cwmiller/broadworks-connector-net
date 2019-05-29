using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ThirdPartyVoiceMailSupportTable { get; set; }
 }
}
