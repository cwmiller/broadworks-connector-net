using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceDelegateListRequest.
    /// Contains a table with table heading:"User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name","Phone Number", "Extension", "Department" and "Email Address".
    /// <see cref="UserMeetMeConferencingGetConferenceDelegateListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:700""}]")]
    public class UserMeetMeConferencingGetConferenceDelegateListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _conferenceDelegateUserTable;

        [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:700")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceDelegateUserTable
        {
            get => _conferenceDelegateUserTable;
            set
            {
                ConferenceDelegateUserTableSpecified = true;
                _conferenceDelegateUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceDelegateUserTableSpecified { get; set; }

    }
}
