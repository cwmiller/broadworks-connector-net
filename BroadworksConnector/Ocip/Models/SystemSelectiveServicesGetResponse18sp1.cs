using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesGetResponse18sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _screenPrivateNumber;

    [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false, Namespace = "")]
    public bool ScreenPrivateNumber {
        get => _screenPrivateNumber;
        set {
            ScreenPrivateNumberSpecified = true;
            _screenPrivateNumber = value;
        }
    }

    [XmlIgnore]
    public bool ScreenPrivateNumberSpecified { get; set; }
}
}
