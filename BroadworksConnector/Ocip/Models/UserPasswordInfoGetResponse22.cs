using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPasswordInfoGetRequest22.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode.
    /// hasPassword
    /// <see cref="UserPasswordInfoGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2723"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2725""}]}]")]
    public class UserPasswordInfoGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isLoginDisabled;

        [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2723")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2725")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2725")]
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

        protected bool _hasPassword;

        [XmlElement(ElementName = "hasPassword", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2723")]
        public bool HasPassword
        {
            get => _hasPassword;
            set
            {
                HasPasswordSpecified = true;
                _hasPassword = value;
            }
        }

        [XmlIgnore]
        protected bool HasPasswordSpecified { get; set; }

    }
}
