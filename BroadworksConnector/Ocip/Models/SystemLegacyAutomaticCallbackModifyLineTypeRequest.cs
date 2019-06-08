using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackModifyLineTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineType _lineType;

    [XmlElement(ElementName = "lineType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineType LineType {
        get => _lineType;
        set {
            LineTypeSpecified = true;
            _lineType = value;
        }
    }

    [XmlIgnore]
    public bool LineTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _matchAction;

    [XmlElement(ElementName = "matchAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction MatchAction {
        get => _matchAction;
        set {
            MatchActionSpecified = true;
            _matchAction = value;
        }
    }

    [XmlIgnore]
    public bool MatchActionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _noMatchAction;

    [XmlElement(ElementName = "noMatchAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction NoMatchAction {
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
