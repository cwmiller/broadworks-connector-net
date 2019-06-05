using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetListInSystemRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName {
        get => _searchCriteriaUserLastName;
        set {
            SearchCriteriaUserLastNameSpecified = true;
            _searchCriteriaUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserLastNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName {
        get => _searchCriteriaUserFirstName;
        set {
            SearchCriteriaUserFirstNameSpecified = true;
            _searchCriteriaUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserFirstNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn {
        get => _searchCriteriaDn;
        set {
            SearchCriteriaDnSpecified = true;
            _searchCriteriaDn = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDnSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress;

    [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress {
        get => _searchCriteriaEmailAddress;
        set {
            SearchCriteriaEmailAddressSpecified = true;
            _searchCriteriaEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEmailAddressSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider _searchCriteriaExactServiceProvider;

    [XmlElement(ElementName = "searchCriteriaExactServiceProvider", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider SearchCriteriaExactServiceProvider {
        get => _searchCriteriaExactServiceProvider;
        set {
            SearchCriteriaExactServiceProviderSpecified = true;
            _searchCriteriaExactServiceProvider = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactServiceProviderSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
        get => _searchCriteriaServiceProviderId;
        set {
            SearchCriteriaServiceProviderIdSpecified = true;
            _searchCriteriaServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup _searchCriteriaExactUserInTrunkGroup;

    [XmlElement(ElementName = "searchCriteriaExactUserInTrunkGroup", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup SearchCriteriaExactUserInTrunkGroup {
        get => _searchCriteriaExactUserInTrunkGroup;
        set {
            SearchCriteriaExactUserInTrunkGroupSpecified = true;
            _searchCriteriaExactUserInTrunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserInTrunkGroupSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserNetworkClassOfService _searchCriteriaExactUserNetworkClassOfService;

    [XmlElement(ElementName = "searchCriteriaExactUserNetworkClassOfService", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserNetworkClassOfService SearchCriteriaExactUserNetworkClassOfService {
        get => _searchCriteriaExactUserNetworkClassOfService;
        set {
            SearchCriteriaExactUserNetworkClassOfServiceSpecified = true;
            _searchCriteriaExactUserNetworkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserNetworkClassOfServiceSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId {
        get => _searchCriteriaUserId;
        set {
            SearchCriteriaUserIdSpecified = true;
            _searchCriteriaUserId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension {
        get => _searchCriteriaExtension;
        set {
            SearchCriteriaExtensionSpecified = true;
            _searchCriteriaExtension = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExtensionSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId;

    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId {
        get => _searchCriteriaResellerId;
        set {
            SearchCriteriaResellerIdSpecified = true;
            _searchCriteriaResellerId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaResellerIdSpecified { get; set; }
}
}
