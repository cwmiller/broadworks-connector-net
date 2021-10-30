using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Call Center subscriber type profile.
    /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22
    /// <see cref="SystemCallProcessingPolicyProfileCallCenterProfileGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:22422""}]")]
    public class SystemCallProcessingPolicyProfileCallCenterProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallProcessingPolicyProfileCallCenterProfileGetResponse>
    {

        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22422")]
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
        protected bool CallProcessingPolicyProfileNameSpecified { get; set; }

    }
}
