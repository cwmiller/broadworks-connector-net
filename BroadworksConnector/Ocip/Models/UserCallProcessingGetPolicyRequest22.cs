using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse22 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: UserCallProcessingGetPolicyRequest22V2 in AS data mode.
    /// <see cref="UserCallProcessingGetPolicyResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallProcessingGetPolicyRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16969""}]")]
    public class UserCallProcessingGetPolicyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallProcessingGetPolicyResponse22>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16969")]
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
