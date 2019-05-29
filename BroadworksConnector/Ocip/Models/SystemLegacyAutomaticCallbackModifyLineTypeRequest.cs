using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackModifyLineTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "lineType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineType LineType { get; set; }
    [XmlElement(ElementName = "matchAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction MatchAction { get; set; }
    [XmlElement(ElementName = "noMatchAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction NoMatchAction { get; set; }
 }
}
