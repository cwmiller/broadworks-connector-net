using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobileManagerAddHomeZoneRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _homeZoneDomainName;

    [XmlElement(ElementName = "homeZoneDomainName", IsNullable = false, Namespace = "")]
    public string HomeZoneDomainName {
        get => _homeZoneDomainName;
        set {
            HomeZoneDomainNameSpecified = true;
            _homeZoneDomainName = value;
        }
    }

    [XmlIgnore]
    public bool HomeZoneDomainNameSpecified { get; set; }
    private string _mobileCountryCode;

    [XmlElement(ElementName = "mobileCountryCode", IsNullable = false, Namespace = "")]
    public string MobileCountryCode {
        get => _mobileCountryCode;
        set {
            MobileCountryCodeSpecified = true;
            _mobileCountryCode = value;
        }
    }

    [XmlIgnore]
    public bool MobileCountryCodeSpecified { get; set; }
    private string _mobileNetworkCode;

    [XmlElement(ElementName = "mobileNetworkCode", IsNullable = false, Namespace = "")]
    public string MobileNetworkCode {
        get => _mobileNetworkCode;
        set {
            MobileNetworkCodeSpecified = true;
            _mobileNetworkCode = value;
        }
    }

    [XmlIgnore]
    public bool MobileNetworkCodeSpecified { get; set; }
    private string _locationAreaCode;

    [XmlElement(ElementName = "locationAreaCode", IsNullable = false, Namespace = "")]
    public string LocationAreaCode {
        get => _locationAreaCode;
        set {
            LocationAreaCodeSpecified = true;
            _locationAreaCode = value;
        }
    }

    [XmlIgnore]
    public bool LocationAreaCodeSpecified { get; set; }
    private string _cellIdentity;

    [XmlElement(ElementName = "cellIdentity", IsNullable = false, Namespace = "")]
    public string CellIdentity {
        get => _cellIdentity;
        set {
            CellIdentitySpecified = true;
            _cellIdentity = value;
        }
    }

    [XmlIgnore]
    public bool CellIdentitySpecified { get; set; }
}
}
