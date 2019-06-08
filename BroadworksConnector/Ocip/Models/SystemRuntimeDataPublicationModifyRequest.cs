using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRuntimeDataPublicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enableRuntimeDataSync;

    [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false, Namespace = "")]
    public bool EnableRuntimeDataSync {
        get => _enableRuntimeDataSync;
        set {
            EnableRuntimeDataSyncSpecified = true;
            _enableRuntimeDataSync = value;
        }
    }

    [XmlIgnore]
    public bool EnableRuntimeDataSyncSpecified { get; set; }
    private int _runtimeDataSyncIntervalInMilliSeconds;

    [XmlElement(ElementName = "runtimeDataSyncIntervalInMilliSeconds", IsNullable = false, Namespace = "")]
    public int RuntimeDataSyncIntervalInMilliSeconds {
        get => _runtimeDataSyncIntervalInMilliSeconds;
        set {
            RuntimeDataSyncIntervalInMilliSecondsSpecified = true;
            _runtimeDataSyncIntervalInMilliSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RuntimeDataSyncIntervalInMilliSecondsSpecified { get; set; }
}
}
