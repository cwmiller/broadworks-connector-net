using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetAvailableDelegateListRequest.
    /// Contains all hosts assigned on a bridge.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension", "Department" and "Email Address".
    /// <see cref="UserMeetMeConferencingGetAvailableDelegateListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:633""}]")]
    public class UserMeetMeConferencingGetAvailableDelegateListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _conferenceDelegateUserTable;

        [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:633")]
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
