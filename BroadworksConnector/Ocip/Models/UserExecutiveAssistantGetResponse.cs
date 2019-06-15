using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserExecutiveAssistantGetRequest.
    /// Contains the executive assistant setting and a table of executives this assistant has been assigned to.
    /// The criteria table's column headings are: "User Id", "Last Name", "First Name", ", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address",
    /// "Assistant Opt-in Status" and "Executive Allow Opt-in".
    /// The possible values for "Assistant Opt-in Status" and "Executive Allow Opt-in" columns are "true" and "false".
        /// <see cref="UserExecutiveAssistantGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveAssistantGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableDivert;

        [XmlElement(ElementName = "enableDivert", IsNullable = false, Namespace = "")]
        public bool EnableDivert {
            get => _enableDivert;
            set {
                EnableDivertSpecified = true;
                _enableDivert = value;
            }
        }

        [XmlIgnore]
        public bool EnableDivertSpecified { get; set; }
        
        private string _divertToPhoneNumber;

        [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = false, Namespace = "")]
        public string DivertToPhoneNumber {
            get => _divertToPhoneNumber;
            set {
                DivertToPhoneNumberSpecified = true;
                _divertToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool DivertToPhoneNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _executiveTable;

        [XmlElement(ElementName = "executiveTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExecutiveTable {
            get => _executiveTable;
            set {
                ExecutiveTableSpecified = true;
                _executiveTable = value;
            }
        }

        [XmlIgnore]
        public bool ExecutiveTableSpecified { get; set; }
        
    }
}
