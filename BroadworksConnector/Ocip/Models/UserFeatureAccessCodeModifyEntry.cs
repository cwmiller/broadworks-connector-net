using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Feature Access Code Entry to be used in all user modify command.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:5722""}]")]
    public class UserFeatureAccessCodeModifyEntry
    {

        protected string _featureAccessCodeName;

        [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5722")]
        [MinLength(1)]
        public string FeatureAccessCodeName
        {
            get => _featureAccessCodeName;
            set
            {
                FeatureAccessCodeNameSpecified = true;
                _featureAccessCodeName = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeNameSpecified { get; set; }

        protected bool _enableFAC;

        [XmlElement(ElementName = "enableFAC", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:5722")]
        public bool EnableFAC
        {
            get => _enableFAC;
            set
            {
                EnableFACSpecified = true;
                _enableFAC = value;
            }
        }

        [XmlIgnore]
        protected bool EnableFACSpecified { get; set; }

    }
}
