using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""edd49e38c60ed5c00d394f2a35697c84:62""}]")]
    public class UserExecutiveAssistantGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableDivert;

        [XmlElement(ElementName = "enableDivert", IsNullable = false, Namespace = "")]
        [Group(@"edd49e38c60ed5c00d394f2a35697c84:62")]
        public bool EnableDivert
        {
            get => _enableDivert;
            set
            {
                EnableDivertSpecified = true;
                _enableDivert = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDivertSpecified { get; set; }

        protected string _divertToPhoneNumber;

        [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"edd49e38c60ed5c00d394f2a35697c84:62")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DivertToPhoneNumber
        {
            get => _divertToPhoneNumber;
            set
            {
                DivertToPhoneNumberSpecified = true;
                _divertToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DivertToPhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _executiveTable;

        [XmlElement(ElementName = "executiveTable", IsNullable = false, Namespace = "")]
        [Group(@"edd49e38c60ed5c00d394f2a35697c84:62")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExecutiveTable
        {
            get => _executiveTable;
            set
            {
                ExecutiveTableSpecified = true;
                _executiveTable = value;
            }
        }

        [XmlIgnore]
        protected bool ExecutiveTableSpecified { get; set; }

    }
}
