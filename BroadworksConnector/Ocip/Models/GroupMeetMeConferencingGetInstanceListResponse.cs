using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _conferenceBridgeTable;

    [XmlElement(ElementName = "conferenceBridgeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceBridgeTable {
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
