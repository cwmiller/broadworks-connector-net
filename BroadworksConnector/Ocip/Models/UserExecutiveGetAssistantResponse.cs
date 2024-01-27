using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserExecutiveGetAssistantsRequest.
    /// Contains the assistant setting and a table of assigned assistants.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address", "Opt-in",
    /// "User External Id" and "User Place Type".
    /// The possible values for "Opt-in" column are "true" and "false".
    /// The possible values for "User Place Type" are: User, Place.
    /// <see cref="UserExecutiveGetAssistantsRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a54ac906cb7002cc1a30fbb0efadb0a:161""}]")]
    public class UserExecutiveGetAssistantResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _allowOptInOut;

        [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:161")]
        public bool AllowOptInOut
        {
            get => _allowOptInOut;
            set
            {
                AllowOptInOutSpecified = true;
                _allowOptInOut = value;
            }
        }

        [XmlIgnore]
        protected bool AllowOptInOutSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assistantUserTable;

        [XmlElement(ElementName = "assistantUserTable", IsNullable = false, Namespace = "")]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:161")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AssistantUserTable
        {
            get => _assistantUserTable;
            set
            {
                AssistantUserTableSpecified = true;
                _assistantUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool AssistantUserTableSpecified { get; set; }

    }
}
