using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSecurityClassificationGetRequest.
    /// <see cref="UserSecurityClassificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7578""}]")]
    public class UserSecurityClassificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7578")]
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
        public bool SecurityClassificationSpecified { get; set; }

    }
}
