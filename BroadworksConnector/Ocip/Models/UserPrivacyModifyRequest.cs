using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Privacy.
    /// This command is supported for regular users only.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b87b6355d5858fdbeb8c1eb05dc1651a:190""}]")]
    public class UserPrivacyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
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
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
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

        private bool _enableAutoAttendantNameDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
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
        protected bool EnableAutoAttendantNameDialingPrivacySpecified { get; set; }

        private bool _enablePhoneStatusPrivacy;

        [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
        public bool EnablePhoneStatusPrivacy
        {
            get => _enablePhoneStatusPrivacy;
            set
            {
                EnablePhoneStatusPrivacySpecified = true;
                _enablePhoneStatusPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnablePhoneStatusPrivacySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _permittedMonitorUserIdList;

        [XmlElement(ElementName = "permittedMonitorUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:190")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList PermittedMonitorUserIdList
        {
            get => _permittedMonitorUserIdList;
            set
            {
                PermittedMonitorUserIdListSpecified = true;
                _permittedMonitorUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool PermittedMonitorUserIdListSpecified { get; set; }

    }
}
