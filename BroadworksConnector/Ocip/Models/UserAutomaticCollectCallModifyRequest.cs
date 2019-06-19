using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify user Automatic Collect Call service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:190""}]")]
    public class UserAutomaticCollectCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:190")]
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

        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:190")]
        public bool EnableAutomaticCollectCall
        {
            get => _enableAutomaticCollectCall;
            set
            {
                EnableAutomaticCollectCallSpecified = true;
                _enableAutomaticCollectCall = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutomaticCollectCallSpecified { get; set; }

    }
}
