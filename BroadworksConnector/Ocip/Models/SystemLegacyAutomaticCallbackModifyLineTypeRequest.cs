using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackModifyLineTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineType _lineType;

    [XmlElement(ElementName = "lineType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineType LineType {
        get => _lineType;
        set {
            LineTypeSpecified = true;
            _lineType = value;
        }
    }

    [XmlIgnore]
    public bool LineTypeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _matchAction;

    [XmlElement(ElementName = "matchAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction MatchAction {
        get => _matchAction;
        set {
            MatchActionSpecified = true;
            _matchAction = value;
        }
    }

    [XmlIgnore]
    public bool MatchActionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _noMatchAction;

    [XmlElement(ElementName = "noMatchAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction NoMatchAction {
        get => _noMatchAction;
        set {
            NoMatchActionSpecified = true;
            _noMatchAction = value;
        }
    }

    [XmlIgnore]
    public bool NoMatchActionSpecified { get; set; }
}
}
