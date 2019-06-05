using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending _dmEventStatusInProgressOrPending;

    [XmlElement(ElementName = "dmEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending DmEventStatusInProgressOrPending {
        get => _dmEventStatusInProgressOrPending;
        set {
            DmEventStatusInProgressOrPendingSpecified = true;
            _dmEventStatusInProgressOrPending = value;
        }
    }

    [XmlIgnore]
    public bool DmEventStatusInProgressOrPendingSpecified { get; set; }
}
}
