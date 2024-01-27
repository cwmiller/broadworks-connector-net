using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserMeetMeConferencingGetConferenceListRequest.
    /// Contains a table with column headings: "Bridge Id", "Conference Id", "Title", "Bridge Name", "Status", "Type", "Start Time", "Last Name", "First Name" and "Host Id".
    /// The column values for "Status" can be Active, Inactive, or Expired.
    /// The column values for "Type" can be Reservationless, One Time, Recurring Daily, Recurring Weekly, Recurring Monthly, or Recurring Yearly.
    /// Start Time is in the format "yyyy-MM-dd'T'HH:mm:ss:SSSZ". Example: 2010-10-01T09:30:00:000-0400.
    /// <see cref="UserMeetMeConferencingGetConferenceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:770""}]")]
    public class UserMeetMeConferencingGetConferenceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _conferenceTable;

        [XmlElement(ElementName = "conferenceTable", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:770")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceTable
        {
            get => _conferenceTable;
            set
            {
                ConferenceTableSpecified = true;
                _conferenceTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceTableSpecified { get; set; }

    }
}
