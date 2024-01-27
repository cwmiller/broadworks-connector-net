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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3242""}]")]
    public class FeatureAccessCodeEntry
    {

        protected string _featureAccessCodeName;

        [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3242")]
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

        protected string _mainCode;

        [XmlElement(ElementName = "mainCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3242")]
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

        protected string _alternateCode;

        [XmlElement(ElementName = "alternateCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3242")]
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
