using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Feature Access Code Entry
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2334""}]")]
    public class FeatureAccessCodeEntry
    {

        private string _featureAccessCodeName;

        [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2334")]
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

        private string _mainCode;

        [XmlElement(ElementName = "mainCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2334")]
        [MinLength(1)]
        [MaxLength(5)]
        public string MainCode
        {
            get => _mainCode;
            set
            {
                MainCodeSpecified = true;
                _mainCode = value;
            }
        }

        [XmlIgnore]
        protected bool MainCodeSpecified { get; set; }

        private string _alternateCode;

        [XmlElement(ElementName = "alternateCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2334")]
        [MinLength(1)]
        [MaxLength(5)]
        public string AlternateCode
        {
            get => _alternateCode;
            set
            {
                AlternateCodeSpecified = true;
                _alternateCode = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCodeSpecified { get; set; }

    }
}
