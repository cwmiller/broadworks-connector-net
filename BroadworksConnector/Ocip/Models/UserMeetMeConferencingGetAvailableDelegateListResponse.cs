using System;
using System.Xml.Serialization;
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
     
    public class UserMeetMeConferencingGetAvailableDelegateListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceDelegateUserTable;

        [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceDelegateUserTable {
            get => _conferenceDelegateUserTable;
            set {
                ConferenceDelegateUserTableSpecified = true;
                _conferenceDelegateUserTable = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceDelegateUserTableSpecified { get; set; }
        
    }
}
