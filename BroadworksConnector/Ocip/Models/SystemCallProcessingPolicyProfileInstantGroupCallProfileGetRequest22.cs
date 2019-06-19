using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type profile.
    /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
    /// ErrorResponse.
    /// <see cref="SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:3843""}]")]
    public class SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:3843")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CallProcessingPolicyProfileName
        {
            get => _callProcessingPolicyProfileName;
            set
            {
                CallProcessingPolicyProfileNameSpecified = true;
                _callProcessingPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        public bool CallProcessingPolicyProfileNameSpecified { get; set; }

    }
}
