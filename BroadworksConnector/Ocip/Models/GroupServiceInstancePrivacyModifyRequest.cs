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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0850ccc76fd27f9c07cb7218b2c1f84:79""}]")]
    public class GroupServiceInstancePrivacyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"f0850ccc76fd27f9c07cb7218b2c1f84:79")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f0850ccc76fd27f9c07cb7218b2c1f84:79")]
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

        protected bool _enableAutoAttendantExtensionDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f0850ccc76fd27f9c07cb7218b2c1f84:79")]
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

        protected bool _enableAutoAttendantNameDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f0850ccc76fd27f9c07cb7218b2c1f84:79")]
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

    }
}
