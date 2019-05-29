using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceRecordingListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceRecordingTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceRecordingTable { get; set; }
 }
}
