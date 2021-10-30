using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Configuration Server for a specified user.
    /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
    /// <see cref="UserBroadWorksCommunicatorGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ba512c9f02a5f24a24d49cc945f1524d:89""}]")]
    public class UserBroadWorksCommunicatorGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBroadWorksCommunicatorGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ba512c9f02a5f24a24d49cc945f1524d:89")]
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
