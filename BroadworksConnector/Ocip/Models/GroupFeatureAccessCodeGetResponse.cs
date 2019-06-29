using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFeatureAccessCodeGetRequest.
    /// 
    /// Replaced by: GroupFeatureAccessCodeGetResponse21 in AS data mode
    /// <see cref="GroupFeatureAccessCodeGetRequest"/>
    /// <see cref="GroupFeatureAccessCodeGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:2424""}]")]
    public class GroupFeatureAccessCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

        [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2424")]
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

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2424")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode
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
