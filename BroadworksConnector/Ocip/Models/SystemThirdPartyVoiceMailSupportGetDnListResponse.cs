using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _thirdPartyVoiceMailSupportTable;

    [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ThirdPartyVoiceMailSupportTable {
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