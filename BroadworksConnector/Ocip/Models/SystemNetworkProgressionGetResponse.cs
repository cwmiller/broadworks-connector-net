using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkProgressionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private int _waitPeriodSeconds;

    [XmlElement(ElementName = "waitPeriodSeconds", IsNullable = false, Namespace = "")]
    public int WaitPeriodSeconds {
        get => _waitPeriodSeconds;
        set {
            WaitPeriodSecondsSpecified = true;
            _waitPeriodSeconds = value;
        }
    }

    [XmlIgnore]
    public bool WaitPeriodSecondsSpecified { get; set; }
}
}
