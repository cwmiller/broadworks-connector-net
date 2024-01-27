using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the settings for the busy lamp field service.
    /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
    /// <see cref="UserBusyLampFieldGetResponse16sp2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b1745b5f688013b73224574a66f4f4b2:172""}]")]
    public class UserBusyLampFieldGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBusyLampFieldGetResponse16sp2>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"b1745b5f688013b73224574a66f4f4b2:172")]
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
