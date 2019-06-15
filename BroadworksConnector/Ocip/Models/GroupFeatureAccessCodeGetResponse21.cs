using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFeatureAccessCodeGetRequest21.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
        /// <see cref="GroupFeatureAccessCodeGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFeatureAccessCodeGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> _featureAccessCode;

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> FeatureAccessCode {
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
