using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDialPlanPolicyGetAccessCodeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _includeCodeForNetworkTranslationsAndRouting;

    [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
    public bool IncludeCodeForNetworkTranslationsAndRouting {
        get => _includeCodeForNetworkTranslationsAndRouting;
        set {
            IncludeCodeForNetworkTranslationsAndRoutingSpecified = true;
            _includeCodeForNetworkTranslationsAndRouting = value;
        }
    }

    [XmlIgnore]
    public bool IncludeCodeForNetworkTranslationsAndRoutingSpecified { get; set; }
    private bool _includeCodeForScreeningServices;

    [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false, Namespace = "")]
    public bool IncludeCodeForScreeningServices {
        get => _includeCodeForScreeningServices;
        set {
            IncludeCodeForScreeningServicesSpecified = true;
            _includeCodeForScreeningServices = value;
        }
    }

    [XmlIgnore]
    public bool IncludeCodeForScreeningServicesSpecified { get; set; }
    private bool _enableSecondaryDialTone;

    [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false, Namespace = "")]
    public bool EnableSecondaryDialTone {
        get => _enableSecondaryDialTone;
        set {
            EnableSecondaryDialToneSpecified = true;
            _enableSecondaryDialTone = value;
        }
    }

    [XmlIgnore]
    public bool EnableSecondaryDialToneSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
