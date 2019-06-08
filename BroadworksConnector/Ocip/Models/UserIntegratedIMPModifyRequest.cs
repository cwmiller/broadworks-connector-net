using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private string _impId;

    [XmlElement(ElementName = "impId", IsNullable = false, Namespace = "")]
    public string ImpId {
        get => _impId;
        set {
            ImpIdSpecified = true;
            _impId = value;
        }
    }

    [XmlIgnore]
    public bool ImpIdSpecified { get; set; }
    private bool _isAlternateImpId;

    [XmlElement(ElementName = "isAlternateImpId", IsNullable = false, Namespace = "")]
    public bool IsAlternateImpId {
        get => _isAlternateImpId;
        set {
            IsAlternateImpIdSpecified = true;
            _isAlternateImpId = value;
        }
    }

    [XmlIgnore]
    public bool IsAlternateImpIdSpecified { get; set; }
}
}
