using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's simultaneous ring service personal setting.
    /// The response is either a UserSimultaneousRingPersonalGetResponse or an ErrorResponse.
    /// Replaced By: UserSimultaneousRingPersonalGetRequest14sp4
    /// <see cref="UserSimultaneousRingPersonalGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserSimultaneousRingPersonalGetRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:46496""}]")]
    public class UserSimultaneousRingPersonalGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserSimultaneousRingPersonalGetResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:46496")]
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
