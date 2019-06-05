using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.LoginType _loginType;

    [XmlElement(ElementName = "loginType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LoginType LoginType {
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
}
}
