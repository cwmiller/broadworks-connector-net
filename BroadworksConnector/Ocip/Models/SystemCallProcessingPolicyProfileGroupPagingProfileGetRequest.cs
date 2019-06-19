using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Group Paging subscriber type
    /// profile.
    /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22
    /// <see cref="SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37891""}]")]
    public class SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37891")]
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
