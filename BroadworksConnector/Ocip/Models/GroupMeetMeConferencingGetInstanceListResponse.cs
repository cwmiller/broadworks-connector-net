using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceBridgeTable;

    [XmlElement(ElementName = "conferenceBridgeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceBridgeTable {
        get => _conferenceBridgeTable;
        set {
            ConferenceBridgeTableSpecified = true;
            _conferenceBridgeTable = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceBridgeTableSpecified { get; set; }
}
}
