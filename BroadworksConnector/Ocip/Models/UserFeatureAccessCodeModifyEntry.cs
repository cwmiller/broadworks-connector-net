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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4548""}]")]
    public class UserFeatureAccessCodeModifyEntry
    {

        private string _featureAccessCodeName;

        [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4548")]
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
        public bool FeatureAccessCodeNameSpecified { get; set; }

        private bool _enableFAC;

        [XmlElement(ElementName = "enableFAC", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4548")]
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
        public bool EnableFACSpecified { get; set; }

    }
}
