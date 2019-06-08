using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceRecordingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceRecordingTable;

    [XmlElement(ElementName = "conferenceRecordingTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceRecordingTable {
        get => _conferenceRecordingTable;
        set {
            ConferenceRecordingTableSpecified = true;
            _conferenceRecordingTable = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceRecordingTableSpecified { get; set; }
}
}
