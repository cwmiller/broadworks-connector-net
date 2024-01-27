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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3271"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3273""}]}]")]
    public class UserPortalPasscodeGetInfoResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isLoginDisabled;

        [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3271")]
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

        protected int _expirationDays;

        [XmlElement(ElementName = "expirationDays", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3273")]
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

        protected bool _doesNotExpire;

        [XmlElement(ElementName = "doesNotExpire", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3273")]
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

        protected string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3271")]
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
