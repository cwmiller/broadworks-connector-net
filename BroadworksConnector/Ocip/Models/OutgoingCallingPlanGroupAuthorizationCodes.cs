using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan Authorization Code for the group default.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:2003""}]")]
    public class OutgoingCallingPlanGroupAuthorizationCodes
    {

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> _codeEntry = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry>();

        [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:2003")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry
        {
            get => _codeEntry;
            set
            {
                CodeEntrySpecified = true;
                _codeEntry = value;
            }
        }

        [XmlIgnore]
        protected bool CodeEntrySpecified { get; set; }

    }
}
