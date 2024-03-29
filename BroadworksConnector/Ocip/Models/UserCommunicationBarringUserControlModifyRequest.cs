using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enabling a profile automatically disables the currently active profile.
    /// Also allows the passcode for the service to be modified and the lockout to be reset.
    /// Admins only need to populate the newPasscode field when changing the passcode.
    /// Users must populate both the oldPasscode and new Passcode fields when changing the passcode.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6844af6fc359ada5d958622d62cbd13f:134""}]")]
    public class UserCommunicationBarringUserControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:134")]
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

        protected int? _enableProfile;

        [XmlElement(ElementName = "enableProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:134")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int? EnableProfile
        {
            get => _enableProfile;
            set
            {
                EnableProfileSpecified = true;
                _enableProfile = value;
            }
        }

        [XmlIgnore]
        protected bool EnableProfileSpecified { get; set; }

        protected string _oldPasscode;

        [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:134")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OldPasscode
        {
            get => _oldPasscode;
            set
            {
                OldPasscodeSpecified = true;
                _oldPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool OldPasscodeSpecified { get; set; }

        protected string _newPasscode;

        [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:134")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewPasscode
        {
            get => _newPasscode;
            set
            {
                NewPasscodeSpecified = true;
                _newPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool NewPasscodeSpecified { get; set; }

        protected bool _resetLockout;

        [XmlElement(ElementName = "resetLockout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6844af6fc359ada5d958622d62cbd13f:134")]
        public bool ResetLockout
        {
            get => _resetLockout;
            set
            {
                ResetLockoutSpecified = true;
                _resetLockout = value;
            }
        }

        [XmlIgnore]
        protected bool ResetLockoutSpecified { get; set; }

    }
}
