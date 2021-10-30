using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's pre-alerting service setting.
    /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
    /// <see cref="UserPreAlertingAnnouncementGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserPreAlertingAnnouncementGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14046""}]")]
    public class UserPreAlertingAnnouncementGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPreAlertingAnnouncementGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14046")]
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
