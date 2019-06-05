using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterGetResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultFromAddress;

    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultFromAddress {
        get => _defaultFromAddress;
        set {
            DefaultFromAddressSpecified = true;
            _defaultFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFromAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes _statisticsSamplingPeriodMinutes;

    [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes {
        get => _statisticsSamplingPeriodMinutes;
        set {
            StatisticsSamplingPeriodMinutesSpecified = true;
            _statisticsSamplingPeriodMinutes = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsSamplingPeriodMinutesSpecified { get; set; }
}
}
