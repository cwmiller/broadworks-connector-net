using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceRecordingListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _conferenceRecordingTable;

    [XmlElement(ElementName = "conferenceRecordingTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceRecordingTable {
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
