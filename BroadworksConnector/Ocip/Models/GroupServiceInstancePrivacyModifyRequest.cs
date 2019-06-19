using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the data associated with Privacy for a service instance.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b87b6355d5858fdbeb8c1eb05dc1651a:79""}]")]
    public class GroupServiceInstancePrivacyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:79")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:79")]
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
        public bool EnableDirectoryPrivacySpecified { get; set; }

        private bool _enableAutoAttendantExtensionDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:79")]
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
        public bool EnableAutoAttendantExtensionDialingPrivacySpecified { get; set; }

        private bool _enableAutoAttendantNameDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:79")]
        public bool EnableAutoAttendantNameDialingPrivacy
        {
            get => _enableAutoAttendantNameDialingPrivacy;
            set
            {
                EnableAutoAttendantNameDialingPrivacySpecified = true;
                _enableAutoAttendantNameDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutoAttendantNameDialingPrivacySpecified { get; set; }

    }
}
