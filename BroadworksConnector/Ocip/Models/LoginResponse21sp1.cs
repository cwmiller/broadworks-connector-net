using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// LoginRequest21sp1/Response21sp1 is 2nd stage of the 2 stage OCI login process.
    /// 
    /// The parameter tokenRevocationTime is represented in the number of milliseconds since
    /// January 1, 1970, 00:00:00 GMT, and it is set to the more current time between the system
    /// level token revocation time and user level token revocation time.
    /// 
    /// Replaced by LoginResponse22V3 in AS data mode.
        /// <see cref="LoginRequest21sp1"/>
        /// <see cref="LoginResponse22V3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class LoginResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.LoginType _loginType;

        [XmlElement(ElementName = "loginType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LoginType LoginType {
            get => _loginType;
            set {
                LoginTypeSpecified = true;
                _loginType = value;
            }
        }

        [XmlIgnore]
        public bool LoginTypeSpecified { get; set; }
        
        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        public string Locale {
            get => _locale;
            set {
                LocaleSpecified = true;
                _locale = value;
            }
        }

        [XmlIgnore]
        public bool LocaleSpecified { get; set; }
        
        private string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        public string Encoding {
            get => _encoding;
            set {
                EncodingSpecified = true;
                _encoding = value;
            }
        }

        [XmlIgnore]
        public bool EncodingSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        public bool IsEnterprise {
            get => _isEnterprise;
            set {
                IsEnterpriseSpecified = true;
                _isEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool IsEnterpriseSpecified { get; set; }
        
        private int _passwordExpiresDays;

        [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
        public int PasswordExpiresDays {
            get => _passwordExpiresDays;
            set {
                PasswordExpiresDaysSpecified = true;
                _passwordExpiresDays = value;
            }
        }

        [XmlIgnore]
        public bool PasswordExpiresDaysSpecified { get; set; }
        
        private string _userDomain;

        [XmlElement(ElementName = "userDomain", IsNullable = false, Namespace = "")]
        public string UserDomain {
            get => _userDomain;
            set {
                UserDomainSpecified = true;
                _userDomain = value;
            }
        }

        [XmlIgnore]
        public bool UserDomainSpecified { get; set; }
        
        private string _tokenRevocationTime;

        [XmlElement(ElementName = "tokenRevocationTime", IsNullable = false, Namespace = "")]
        public string TokenRevocationTime {
            get => _tokenRevocationTime;
            set {
                TokenRevocationTimeSpecified = true;
                _tokenRevocationTime = value;
            }
        }

        [XmlIgnore]
        public bool TokenRevocationTimeSpecified { get; set; }
        
    }
}
