using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _conferenceTable;

    [XmlElement(ElementName = "conferenceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceTable {
        get => _conferenceTable;
        set {
            ConferenceTableSpecified = true;
            _conferenceTable = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceTableSpecified { get; set; }
}
}
