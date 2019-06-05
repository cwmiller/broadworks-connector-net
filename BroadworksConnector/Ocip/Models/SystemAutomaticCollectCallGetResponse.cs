using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableAutomaticCollectCall;

    [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
    public bool EnableAutomaticCollectCall {
        get => _enableAutomaticCollectCall;
        set {
            EnableAutomaticCollectCallSpecified = true;
            _enableAutomaticCollectCall = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutomaticCollectCallSpecified { get; set; }
    private bool _enableConnectTone;

    [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
    public bool EnableConnectTone {
        get => _enableConnectTone;
        set {
            EnableConnectToneSpecified = true;
            _enableConnectTone = value;
        }
    }

    [XmlIgnore]
    public bool EnableConnectToneSpecified { get; set; }
}
}
