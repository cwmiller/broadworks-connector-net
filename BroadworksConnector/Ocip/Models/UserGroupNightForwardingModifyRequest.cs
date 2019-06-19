using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Group Night Forwarding user parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1a3849774e8d2ffd90c3a2c57cbdd7a0:183""}]")]
    public class UserGroupNightForwardingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:183")]
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
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

        [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:183")]
        public BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding
        {
            get => _nightForwarding;
            set
            {
                NightForwardingSpecified = true;
                _nightForwarding = value;
            }
        }

        [XmlIgnore]
        public bool NightForwardingSpecified { get; set; }

    }
}
