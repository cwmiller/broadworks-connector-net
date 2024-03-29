using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserMeetMeConferencingGetConferenceRecordingListRequest.
    /// Contains a table with column headings: "Bridge Id", "Conference Id", "Conference Title", "Bridge Name", "Start Time", "File Size", and "URL".
    /// Start Time is in the format "yyyy-MM-dd'T'HH:mm:ss:SSSZ". Example: 2010-10-01T09:30:00:000-0400.
    /// <see cref="UserMeetMeConferencingGetConferenceRecordingListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:803""}]")]
    public class UserMeetMeConferencingGetConferenceRecordingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _conferenceRecordingTable;

        [XmlElement(ElementName = "conferenceRecordingTable", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:803")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceRecordingTable
        {
            get => _conferenceRecordingTable;
            set
            {
                ConferenceRecordingTableSpecified = true;
                _conferenceRecordingTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceRecordingTableSpecified { get; set; }

    }
}
