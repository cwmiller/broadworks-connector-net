using System;
using System.Xml.Serialization;
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
     
    public class UserPushToTalkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _allowAutoAnswer;

        [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
        public bool AllowAutoAnswer {
            get => _allowAutoAnswer;
            set {
                AllowAutoAnswerSpecified = true;
                _allowAutoAnswer = value;
            }
        }

        [XmlIgnore]
        public bool AllowAutoAnswerSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

        [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection {
            get => _outgoingConnectionSelection;
            set {
                OutgoingConnectionSelectionSpecified = true;
                _outgoingConnectionSelection = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingConnectionSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

        [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection {
            get => _accessListSelection;
            set {
                AccessListSelectionSpecified = true;
                _accessListSelection = value;
            }
        }

        [XmlIgnore]
        public bool AccessListSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _selectedUserTable;

        [XmlElement(ElementName = "selectedUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SelectedUserTable {
            get => _selectedUserTable;
            set {
                SelectedUserTableSpecified = true;
                _selectedUserTable = value;
            }
        }

        [XmlIgnore]
        public bool SelectedUserTableSpecified { get; set; }
        
    }
}
