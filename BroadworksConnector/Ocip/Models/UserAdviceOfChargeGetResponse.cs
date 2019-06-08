using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadWorksConnector.Ocip.Models.AdviceOfChargeType _aocType;

    [XmlElement(ElementName = "aocType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AdviceOfChargeType AocType {
        get => _aocType;
        set {
            AocTypeSpecified = true;
            _aocType = value;
        }
    }

    [XmlIgnore]
    public bool AocTypeSpecified { get; set; }
}
}
