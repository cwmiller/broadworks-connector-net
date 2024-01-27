using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse21sp2 or an
    /// ErrorResponse.
    /// Replaced by: UserCallProcessingGetPolicyRequest22 in AS data mode
    /// <see cref="UserCallProcessingGetPolicyResponse21sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallProcessingGetPolicyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16950""}]")]
    public class UserCallProcessingGetPolicyRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallProcessingGetPolicyResponse21sp2>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16950")]
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
