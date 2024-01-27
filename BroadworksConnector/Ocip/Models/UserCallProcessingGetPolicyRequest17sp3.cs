using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse17sp3 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: UserCallProcessingGetPolicyRequest17Sp4
    /// <see cref="UserCallProcessingGetPolicyResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallProcessingGetPolicyRequest17Sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:41720""}]")]
    public class UserCallProcessingGetPolicyRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallProcessingGetPolicyResponse17sp3>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:41720")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

    }
}
