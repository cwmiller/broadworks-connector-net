using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetInstancePagedSortedRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address".
    /// The users are in the table are in the order they will try to be parked on.
    /// <see cref="GroupCallParkGetInstancePagedSortedRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:401""}]")]
    public class GroupCallParkGetInstancePagedSortedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _recallAlternateUserId;

        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:401")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RecallAlternateUserId
        {
            get => _recallAlternateUserId;
            set
            {
                RecallAlternateUserIdSpecified = true;
                _recallAlternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool RecallAlternateUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:401")]
        public BroadWorksConnector.Ocip.Models.CallParkRecallTo RecallTo
        {
            get => _recallTo;
            set
            {
                RecallToSpecified = true;
                _recallTo = value;
            }
        }

        [XmlIgnore]
        protected bool RecallToSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:401")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}
