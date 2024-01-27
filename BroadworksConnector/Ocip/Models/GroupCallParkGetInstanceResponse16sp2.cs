using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetInstanceRequest16sp2.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address".
    /// The users are in the table are in the order they will try to be parked on.
    /// <see cref="GroupCallParkGetInstanceRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b6fd73d148b9b309dce1d2f04516ddfa:439""}]")]
    public class GroupCallParkGetInstanceResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _recallAlternateUserId;

        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:439")]
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

        protected BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:439")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:439")]
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
