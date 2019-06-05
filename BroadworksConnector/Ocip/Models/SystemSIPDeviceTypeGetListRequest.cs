using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceType> _searchCriteriaDeviceType;

    [XmlElement(ElementName = "searchCriteriaDeviceType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceType> SearchCriteriaDeviceType {
        get => _searchCriteriaDeviceType;
        set {
            SearchCriteriaDeviceTypeSpecified = true;
            _searchCriteriaDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceTypeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType _searchCriteriaExactSignalingAddressType;

    [XmlElement(ElementName = "searchCriteriaExactSignalingAddressType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType SearchCriteriaExactSignalingAddressType {
        get => _searchCriteriaExactSignalingAddressType;
        set {
            SearchCriteriaExactSignalingAddressTypeSpecified = true;
            _searchCriteriaExactSignalingAddressType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactSignalingAddressTypeSpecified { get; set; }
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
    private bool _includeSystemLevel;

    [XmlElement(ElementName = "includeSystemLevel", IsNullable = false, Namespace = "")]
    public bool IncludeSystemLevel {
        get => _includeSystemLevel;
        set {
            IncludeSystemLevelSpecified = true;
            _includeSystemLevel = value;
        }
    }

    [XmlIgnore]
    public bool IncludeSystemLevelSpecified { get; set; }
}
}
