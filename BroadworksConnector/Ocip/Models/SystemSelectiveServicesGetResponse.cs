using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

    [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination {
        get => _scheduleCombination;
        set {
            ScheduleCombinationSpecified = true;
            _scheduleCombination = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleCombinationSpecified { get; set; }
}
}
