using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationGetResponse18sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

    [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NumberActivationMode NumberActivationMode {
        get => _numberActivationMode;
        set {
            NumberActivationModeSpecified = true;
            _numberActivationMode = value;
        }
    }

    [XmlIgnore]
    public bool NumberActivationModeSpecified { get; set; }
}
}
