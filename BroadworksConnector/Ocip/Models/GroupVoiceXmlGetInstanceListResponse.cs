using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceXmlGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _voiceXmlTable;

    [XmlElement(ElementName = "voiceXmlTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable VoiceXmlTable {
        get => _voiceXmlTable;
        set {
            VoiceXmlTableSpecified = true;
            _voiceXmlTable = value;
        }
    }

    [XmlIgnore]
    public bool VoiceXmlTableSpecified { get; set; }
}
}
