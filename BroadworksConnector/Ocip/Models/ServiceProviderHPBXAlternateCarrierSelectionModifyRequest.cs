using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderHPBXAlternateCarrierSelectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _processCbcCarrierSelection;

    [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false, Namespace = "")]
    public bool ProcessCbcCarrierSelection {
        get => _processCbcCarrierSelection;
        set {
            ProcessCbcCarrierSelectionSpecified = true;
            _processCbcCarrierSelection = value;
        }
    }

    [XmlIgnore]
    public bool ProcessCbcCarrierSelectionSpecified { get; set; }
    private string _preselectedLocalCarrier;

    [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = true, Namespace = "")]
    public string PreselectedLocalCarrier {
        get => _preselectedLocalCarrier;
        set {
            PreselectedLocalCarrierSpecified = true;
            _preselectedLocalCarrier = value;
        }
    }

    [XmlIgnore]
    public bool PreselectedLocalCarrierSpecified { get; set; }
    private string _preselectedDistantCarrier;

    [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = true, Namespace = "")]
    public string PreselectedDistantCarrier {
        get => _preselectedDistantCarrier;
        set {
            PreselectedDistantCarrierSpecified = true;
            _preselectedDistantCarrier = value;
        }
    }

    [XmlIgnore]
    public bool PreselectedDistantCarrierSpecified { get; set; }
}
}
