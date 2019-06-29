using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSecurityClassificationGetRequest22.
    /// The following elements are only used in Amplify data mode and not returned in AS and XS data mode:
    /// customizedSecurityClassification
    /// <see cref="UserSecurityClassificationGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:329""}]")]
    public class UserSecurityClassificationGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:329")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SecurityClassification
        {
            get => _securityClassification;
            set
            {
                SecurityClassificationSpecified = true;
                _securityClassification = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationSpecified { get; set; }

        private string _customizedSecurityClassification;

        [XmlElement(ElementName = "customizedSecurityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:329")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CustomizedSecurityClassification
        {
            get => _customizedSecurityClassification;
            set
            {
                CustomizedSecurityClassificationSpecified = true;
                _customizedSecurityClassification = value;
            }
        }

        [XmlIgnore]
        protected bool CustomizedSecurityClassificationSpecified { get; set; }

    }
}
