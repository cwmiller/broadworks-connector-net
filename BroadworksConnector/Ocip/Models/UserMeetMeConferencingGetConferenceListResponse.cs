using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceTable;

    [XmlElement(ElementName = "conferenceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceTable {
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
