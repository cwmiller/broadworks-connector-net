using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMWIDeliveryToMobileEndpointModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel _useSettingLevel;

    [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel {
        get => _useSettingLevel;
        set {
            UseSettingLevelSpecified = true;
            _useSettingLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingLevelSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> _templateActivation;

    [XmlElement(ElementName = "templateActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> TemplateActivation {
        get => _templateActivation;
        set {
            TemplateActivationSpecified = true;
            _templateActivation = value;
        }
    }

    [XmlIgnore]
    public bool TemplateActivationSpecified { get; set; }
}
}
