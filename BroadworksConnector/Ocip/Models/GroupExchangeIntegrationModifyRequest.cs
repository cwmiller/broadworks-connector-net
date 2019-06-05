using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExchangeIntegrationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    private bool _enableExchangeIntegration;

    [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false, Namespace = "")]
    public bool EnableExchangeIntegration {
        get => _enableExchangeIntegration;
        set {
            EnableExchangeIntegrationSpecified = true;
            _enableExchangeIntegration = value;
        }
    }

    [XmlIgnore]
    public bool EnableExchangeIntegrationSpecified { get; set; }
    private string _exchangeURL;

    [XmlElement(ElementName = "exchangeURL", IsNullable = true, Namespace = "")]
    public string ExchangeURL {
        get => _exchangeURL;
        set {
            ExchangeURLSpecified = true;
            _exchangeURL = value;
        }
    }

    [XmlIgnore]
    public bool ExchangeURLSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExchangeUserNamePassword _exchangeCredentials;

    [XmlElement(ElementName = "exchangeCredentials", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExchangeUserNamePassword ExchangeCredentials {
        get => _exchangeCredentials;
        set {
            ExchangeCredentialsSpecified = true;
            _exchangeCredentials = value;
        }
    }

    [XmlIgnore]
    public bool ExchangeCredentialsSpecified { get; set; }
}
}
