using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a system Security Classification.
    /// The response is either SystemSecurityClassificationGetClassificationResponse or ErrorResponse.
    /// <see cref="SystemSecurityClassificationGetClassificationResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""435c279b3e6710f4ada60ed66a93d278:135""}]")]
    public class SystemSecurityClassificationGetClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSecurityClassificationGetClassificationResponse>
    {

        protected string _securityClassificationName;

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:135")]
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
