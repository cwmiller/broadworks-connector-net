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
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address" and "Opt-in".
    /// The possible values for "Opt-in" column are "true" and "false".
    /// <see cref="UserExecutiveGetAssistantsRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9a6dbade05624033cf7fe782b7c9a9a7:160""}]")]
    public class UserExecutiveGetAssistantResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _allowOptInOut;

        [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:160")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _assistantUserTable;

        [XmlElement(ElementName = "assistantUserTable", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:160")]
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
