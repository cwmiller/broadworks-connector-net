using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkServerSyncParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableSync;

    [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
    public bool EnableSync {
        get => _enableSync;
        set {
            EnableSyncSpecified = true;
            _enableSync = value;
        }
    }

    [XmlIgnore]
    public bool EnableSyncSpecified { get; set; }
}
}
