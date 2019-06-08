using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHomeNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaHomeMscAddress> _searchCriteriaHomeMscAddress;

    [XmlElement(ElementName = "searchCriteriaHomeMscAddress", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaHomeMscAddress> SearchCriteriaHomeMscAddress {
        get => _searchCriteriaHomeMscAddress;
        set {
            SearchCriteriaHomeMscAddressSpecified = true;
            _searchCriteriaHomeMscAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaHomeMscAddressSpecified { get; set; }
}
}
