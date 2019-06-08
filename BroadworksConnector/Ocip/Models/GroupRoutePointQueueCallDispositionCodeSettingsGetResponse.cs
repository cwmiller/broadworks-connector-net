using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointQueueCallDispositionCodeSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableCallDispositionCodes;

    [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false, Namespace = "")]
    public bool EnableCallDispositionCodes {
        get => _enableCallDispositionCodes;
        set {
            EnableCallDispositionCodesSpecified = true;
            _enableCallDispositionCodes = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallDispositionCodesSpecified { get; set; }
    private bool _includeOrganizationCodes;

    [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false, Namespace = "")]
    public bool IncludeOrganizationCodes {
        get => _includeOrganizationCodes;
        set {
            IncludeOrganizationCodesSpecified = true;
            _includeOrganizationCodes = value;
        }
    }

    [XmlIgnore]
    public bool IncludeOrganizationCodesSpecified { get; set; }
    private bool _forceUseOfCallDispositionCodes;

    [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false, Namespace = "")]
    public bool ForceUseOfCallDispositionCodes {
        get => _forceUseOfCallDispositionCodes;
        set {
            ForceUseOfCallDispositionCodesSpecified = true;
            _forceUseOfCallDispositionCodes = value;
        }
    }

    [XmlIgnore]
    public bool ForceUseOfCallDispositionCodesSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel _defaultCallDispositionCode;

    [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallDispositionCodeWithLevel DefaultCallDispositionCode {
        get => _defaultCallDispositionCode;
        set {
            DefaultCallDispositionCodeSpecified = true;
            _defaultCallDispositionCode = value;
        }
    }

    [XmlIgnore]
    public bool DefaultCallDispositionCodeSpecified { get; set; }
}
}
