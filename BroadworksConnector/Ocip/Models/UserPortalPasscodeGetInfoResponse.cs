using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPortalPasscodeGetInfoRequest.
    /// <see cref="UserPortalPasscodeGetInfoRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3229"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3231""}]}]")]
    public class UserPortalPasscodeGetInfoResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isLoginDisabled;

        [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3229")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3231")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3231")]
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

        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3229")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

    }
}
