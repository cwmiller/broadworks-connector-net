using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAutomaticCollectCallGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
