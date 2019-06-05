using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderFeatureAccessCodeModifyListRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> _featureAccessCode;

    [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> FeatureAccessCode {
        get => _featureAccessCode;
        set {
            FeatureAccessCodeSpecified = true;
            _featureAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool FeatureAccessCodeSpecified { get; set; }
}
}
