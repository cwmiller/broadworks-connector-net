using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFeatureAccessCodeModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

    [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel {
        get => _useFeatureAccessCodeLevel;
        set {
            UseFeatureAccessCodeLevelSpecified = true;
            _useFeatureAccessCodeLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseFeatureAccessCodeLevelSpecified { get; set; }
    private bool _restoreDefaultCodes;

    [XmlElement(ElementName = "restoreDefaultCodes", IsNullable = false, Namespace = "")]
    public bool RestoreDefaultCodes {
        get => _restoreDefaultCodes;
        set {
            RestoreDefaultCodesSpecified = true;
            _restoreDefaultCodes = value;
        }
    }

    [XmlIgnore]
    public bool RestoreDefaultCodesSpecified { get; set; }
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
