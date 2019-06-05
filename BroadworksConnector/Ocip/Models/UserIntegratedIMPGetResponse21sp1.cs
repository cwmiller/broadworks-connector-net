using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserIntegratedIMPGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
