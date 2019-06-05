using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.CallDispositionCodeWithLevel _defaultCallDispositionCode;

    [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallDispositionCodeWithLevel DefaultCallDispositionCode {
        get => _defaultCallDispositionCode;
        set {
            DefaultCallDispositionCodeSpecified = true;
            _defaultCallDispositionCode = value;
        }
    }

    [XmlIgnore]
    public bool DefaultCallDispositionCodeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallDispositionCodeActivation> _callDispositionCodeActivation;

    [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation {
        get => _callDispositionCodeActivation;
        set {
            CallDispositionCodeActivationSpecified = true;
            _callDispositionCodeActivation = value;
        }
    }

    [XmlIgnore]
    public bool CallDispositionCodeActivationSpecified { get; set; }
}
}
