using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse17sp4 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: UserCallProcessingGetPolicyRequest18
    /// <see cref="UserCallProcessingGetPolicyResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallProcessingGetPolicyRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41036""}]")]
    public class UserCallProcessingGetPolicyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallProcessingGetPolicyResponse17sp4>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41036")]
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
