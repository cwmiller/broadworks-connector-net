using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemShInterfaceRefreshTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isRunning;

    [XmlElement(ElementName = "isRunning", IsNullable = false, Namespace = "")]
    public bool IsRunning {
        get => _isRunning;
        set {
            IsRunningSpecified = true;
            _isRunning = value;
        }
    }

    [XmlIgnore]
    public bool IsRunningSpecified { get; set; }
    private int _numberPublicIdentityRefreshesStarted;

    [XmlElement(ElementName = "numberPublicIdentityRefreshesStarted", IsNullable = false, Namespace = "")]
    public int NumberPublicIdentityRefreshesStarted {
        get => _numberPublicIdentityRefreshesStarted;
        set {
            NumberPublicIdentityRefreshesStartedSpecified = true;
            _numberPublicIdentityRefreshesStarted = value;
        }
    }

    [XmlIgnore]
    public bool NumberPublicIdentityRefreshesStartedSpecified { get; set; }
    private int _numberPublicIdentities;

    [XmlElement(ElementName = "numberPublicIdentities", IsNullable = false, Namespace = "")]
    public int NumberPublicIdentities {
        get => _numberPublicIdentities;
        set {
            NumberPublicIdentitiesSpecified = true;
            _numberPublicIdentities = value;
        }
    }

    [XmlIgnore]
    public bool NumberPublicIdentitiesSpecified { get; set; }
}
}
