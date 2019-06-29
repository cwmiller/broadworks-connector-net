using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest.
    /// Replaced By: UserPortalPasscodeGetInfoResponse
    /// <see cref="UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest"/>
    /// <see cref="UserPortalPasscodeGetInfoResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7873"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7875""}]}]")]
    public class UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isLoginDisabled;

        [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7873")]
        public bool IsLoginDisabled
        {
            get => _isLoginDisabled;
            set
            {
                IsLoginDisabledSpecified = true;
                _isLoginDisabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsLoginDisabledSpecified { get; set; }

        private int _expirationDays;

        [XmlElement(ElementName = "expirationDays", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7875")]
        public int ExpirationDays
        {
            get => _expirationDays;
            set
            {
                ExpirationDaysSpecified = true;
                _expirationDays = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirationDaysSpecified { get; set; }

        private bool _doesNotExpire;

        [XmlElement(ElementName = "doesNotExpire", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7875")]
        public bool DoesNotExpire
        {
            get => _doesNotExpire;
            set
            {
                DoesNotExpireSpecified = true;
                _doesNotExpire = value;
            }
        }

        [XmlIgnore]
        protected bool DoesNotExpireSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7873")]
        [MinLength(1)]
        [MaxLength(60)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

    }
}
