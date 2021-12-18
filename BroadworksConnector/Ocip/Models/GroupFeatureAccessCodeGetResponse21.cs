using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5828""}]")]
    public class GroupFeatureAccessCodeGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

        [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5828")]
        public BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel
        {
            get => _useFeatureAccessCodeLevel;
            set
            {
                UseFeatureAccessCodeLevelSpecified = true;
                _useFeatureAccessCodeLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseFeatureAccessCodeLevelSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5828")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeReadEntry> FeatureAccessCode
        {
            get => _featureAccessCode;
            set
            {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeSpecified { get; set; }

    }
}
