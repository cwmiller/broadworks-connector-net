using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPasswordInfoGetRequest.
    /// <see cref="UserPasswordInfoGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2732"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2734""}]}]")]
    public class UserPasswordInfoGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isLoginDisabled;

        [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2732")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2734")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2734")]
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

    }
}
