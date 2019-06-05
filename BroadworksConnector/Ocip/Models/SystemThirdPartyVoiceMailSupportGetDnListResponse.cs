using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _thirdPartyVoiceMailSupportTable;

    [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ThirdPartyVoiceMailSupportTable {
        get => _thirdPartyVoiceMailSupportTable;
        set {
            ThirdPartyVoiceMailSupportTableSpecified = true;
            _thirdPartyVoiceMailSupportTable = value;
        }
    }

    [XmlIgnore]
    public bool ThirdPartyVoiceMailSupportTableSpecified { get; set; }
}
}
