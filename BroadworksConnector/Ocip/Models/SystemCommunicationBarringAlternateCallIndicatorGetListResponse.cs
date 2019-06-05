using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringAlternateCallIndicatorGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

    [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable {
        get => _alternateCallIndicatorTable;
        set {
            AlternateCallIndicatorTableSpecified = true;
            _alternateCallIndicatorTable = value;
        }
    }

    [XmlIgnore]
    public bool AlternateCallIndicatorTableSpecified { get; set; }
}
}
