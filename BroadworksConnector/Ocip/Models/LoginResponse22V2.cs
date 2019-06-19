using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the OCI login request.
    /// 
    /// Replaced by LoginResponse22V3 in AS data mode.
    /// <see cref="LoginResponse22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5341""}]")]
    public class LoginResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.LoginType22 _loginType;

        [XmlElement(ElementName = "loginType", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        public BroadWorksConnector.Ocip.Models.LoginType22 LoginType
        {
            get => _loginType;
            set
            {
                LoginTypeSpecified = true;
                _loginType = value;
            }
        }

        [XmlIgnore]
        public bool LoginTypeSpecified { get; set; }

        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MaxLength(5)]
        public string Locale
        {
            get => _locale;
            set
            {
                LocaleSpecified = true;
                _locale = value;
            }
        }

        [XmlIgnore]
        public bool LocaleSpecified { get; set; }

        private string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Encoding
        {
            get => _encoding;
            set
            {
                EncodingSpecified = true;
                _encoding = value;
            }
        }

        [XmlIgnore]
        public bool EncodingSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        public bool IsEnterprise
        {
            get => _isEnterprise;
            set
            {
                IsEnterpriseSpecified = true;
                _isEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool IsEnterpriseSpecified { get; set; }

        private int _passwordExpiresDays;

        [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        public int PasswordExpiresDays
        {
            get => _passwordExpiresDays;
            set
            {
                PasswordExpiresDaysSpecified = true;
                _passwordExpiresDays = value;
            }
        }

        [XmlIgnore]
        public bool PasswordExpiresDaysSpecified { get; set; }

        private string _userDomain;

        [XmlElement(ElementName = "userDomain", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UserDomain
        {
            get => _userDomain;
            set
            {
                UserDomainSpecified = true;
                _userDomain = value;
            }
        }

        [XmlIgnore]
        public bool UserDomainSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5341")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }

    }
}
