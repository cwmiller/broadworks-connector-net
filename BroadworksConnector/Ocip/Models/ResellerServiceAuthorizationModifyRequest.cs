using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerServiceAuthorizationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.FileResource _serviceOffering;

    [XmlElement(ElementName = "serviceOffering", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.FileResource ServiceOffering {
        get => _serviceOffering;
        set {
            ServiceOfferingSpecified = true;
            _serviceOffering = value;
        }
    }

    [XmlIgnore]
    public bool ServiceOfferingSpecified { get; set; }
}
}
