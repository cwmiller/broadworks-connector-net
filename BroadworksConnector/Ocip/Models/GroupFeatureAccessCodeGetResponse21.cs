using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFeatureAccessCodeGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private List<BroadworksConnector.Ocip.Models.FeatureAccessCodeReadEntry> _featureAccessCode;

    [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeReadEntry> FeatureAccessCode {
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
