using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _getDefaultMenuKeys;

    [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
    public bool GetDefaultMenuKeys {
        get => _getDefaultMenuKeys;
        set {
            GetDefaultMenuKeysSpecified = true;
            _getDefaultMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool GetDefaultMenuKeysSpecified { get; set; }
}
}
