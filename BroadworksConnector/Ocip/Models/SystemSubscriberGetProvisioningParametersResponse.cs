using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberGetProvisioningParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _configurableCLIDNormalization;

    [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
    public bool ConfigurableCLIDNormalization {
        get => _configurableCLIDNormalization;
        set {
            ConfigurableCLIDNormalizationSpecified = true;
            _configurableCLIDNormalization = value;
        }
    }

    [XmlIgnore]
    public bool ConfigurableCLIDNormalizationSpecified { get; set; }
}
}
