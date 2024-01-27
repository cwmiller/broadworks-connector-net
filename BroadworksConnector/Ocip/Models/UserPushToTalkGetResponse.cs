using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushToTalkGetRequest.  It returns the service settings and a
    /// 9 column selected user table with the following column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "IMP Id".
    /// <see cref="UserPushToTalkGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""22c82692327758edb5adf1f1db18fc71:104""}]")]
    public class UserPushToTalkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _allowAutoAnswer;

        [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"22c82692327758edb5adf1f1db18fc71:104")]
        public bool AllowAutoAnswer
        {
            get => _allowAutoAnswer;
            set
            {
                AllowAutoAnswerSpecified = true;
                _allowAutoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAutoAnswerSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

        [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
        [Group(@"22c82692327758edb5adf1f1db18fc71:104")]
        public BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection
        {
            get => _outgoingConnectionSelection;
            set
            {
                OutgoingConnectionSelectionSpecified = true;
                _outgoingConnectionSelection = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingConnectionSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

        [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
        [Group(@"22c82692327758edb5adf1f1db18fc71:104")]
        public BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection
        {
            get => _accessListSelection;
            set
            {
                AccessListSelectionSpecified = true;
                _accessListSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AccessListSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _selectedUserTable;

        [XmlElement(ElementName = "selectedUserTable", IsNullable = false, Namespace = "")]
        [Group(@"22c82692327758edb5adf1f1db18fc71:104")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SelectedUserTable
        {
            get => _selectedUserTable;
            set
            {
                SelectedUserTableSpecified = true;
                _selectedUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool SelectedUserTableSpecified { get; set; }

    }
}
