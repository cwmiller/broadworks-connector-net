using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

    [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination {
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
