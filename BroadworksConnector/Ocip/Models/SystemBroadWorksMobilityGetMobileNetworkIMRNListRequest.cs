using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetMobileNetworkIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _mobileNetworkName;

    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
    public string MobileNetworkName {
        get => _mobileNetworkName;
        set {
            MobileNetworkNameSpecified = true;
            _mobileNetworkName = value;
        }
    }

    [XmlIgnore]
    public bool MobileNetworkNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN;

    [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN {
        get => _searchCriteriaIMRN;
        set {
            SearchCriteriaIMRNSpecified = true;
            _searchCriteriaIMRN = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaIMRNSpecified { get; set; }
}
}
