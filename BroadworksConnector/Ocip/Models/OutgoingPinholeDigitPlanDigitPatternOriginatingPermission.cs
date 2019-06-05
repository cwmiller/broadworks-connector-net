using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternOriginatingPermission 
{
    private string _digitPatternName;

    [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
    public string DigitPatternName {
        get => _digitPatternName;
        set {
            DigitPatternNameSpecified = true;
            _digitPatternName = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanOriginatingPermission _permission;

    [XmlElement(ElementName = "permission", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanOriginatingPermission Permission {
        get => _permission;
        set {
            PermissionSpecified = true;
            _permission = value;
        }
    }

    [XmlIgnore]
    public bool PermissionSpecified { get; set; }
}
}
