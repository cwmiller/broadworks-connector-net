using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFeatureAccessCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

    [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel {
        get => _useFeatureAccessCodeLevel;
        set {
            UseFeatureAccessCodeLevelSpecified = true;
            _useFeatureAccessCodeLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseFeatureAccessCodeLevelSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode;

    [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode {
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
