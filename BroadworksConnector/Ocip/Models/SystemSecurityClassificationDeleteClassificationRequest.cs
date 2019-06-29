using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a System Security Classification
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:119""}]")]
    public class SystemSecurityClassificationDeleteClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _securityClassificationName;

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:119")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SecurityClassificationName
        {
            get => _securityClassificationName;
            set
            {
                SecurityClassificationNameSpecified = true;
                _securityClassificationName = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationNameSpecified { get; set; }

    }
}
