using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupServiceInstancePrivacyGetRequest.
    /// Replaced by: GroupServiceInstancePrivacyGetResponse17sp4
    /// <see cref="GroupServiceInstancePrivacyGetRequest"/>
    /// <see cref="GroupServiceInstancePrivacyGetResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:12769""}]")]
    public class GroupServiceInstancePrivacyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12769")]
        public bool EnableDirectoryPrivacy
        {
            get => _enableDirectoryPrivacy;
            set
            {
                EnableDirectoryPrivacySpecified = true;
                _enableDirectoryPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDirectoryPrivacySpecified { get; set; }

        private bool _enableAutoAttendantExtensionDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12769")]
        public bool EnableAutoAttendantExtensionDialingPrivacy
        {
            get => _enableAutoAttendantExtensionDialingPrivacy;
            set
            {
                EnableAutoAttendantExtensionDialingPrivacySpecified = true;
                _enableAutoAttendantExtensionDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoAttendantExtensionDialingPrivacySpecified { get; set; }

    }
}
