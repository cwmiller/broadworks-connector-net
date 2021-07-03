using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFeatureAccessCodeGetRequest20.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by : GroupFeatureAccessCodeGetResponse21
    /// <see cref="GroupFeatureAccessCodeGetRequest20"/>
    /// <see cref="GroupFeatureAccessCodeGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9724""}]")]
    public class GroupFeatureAccessCodeGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

        [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9724")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9724")]
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
