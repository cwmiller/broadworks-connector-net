using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSecurityClassificationGetRequest22.
    /// The following elements are not returned in AS and XS data mode:
    /// customizedSecurityClassification
    /// <see cref="UserSecurityClassificationGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""435c279b3e6710f4ada60ed66a93d278:329""}]")]
    public class UserSecurityClassificationGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:329")]
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

        protected string _customizedSecurityClassification;

        [XmlElement(ElementName = "customizedSecurityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:329")]
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
