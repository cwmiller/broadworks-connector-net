using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress> _searchCriteriaRoamingMscAddress;

    [XmlElement(ElementName = "searchCriteriaRoamingMscAddress", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress> SearchCriteriaRoamingMscAddress {
        get => _searchCriteriaRoamingMscAddress;
        set {
            SearchCriteriaRoamingMscAddressSpecified = true;
            _searchCriteriaRoamingMscAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaRoamingMscAddressSpecified { get; set; }
}
}
