using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceXmlGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _voiceXmlTable;

    [XmlElement(ElementName = "voiceXmlTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable VoiceXmlTable {
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
