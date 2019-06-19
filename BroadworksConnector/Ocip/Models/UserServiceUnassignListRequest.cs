using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests to unassign the user services and service packs for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3850""}]")]
    public class UserServiceUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3850")]
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

        private List<BroadWorksConnector.Ocip.Models.UserService> _serviceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3850")]
        public List<BroadWorksConnector.Ocip.Models.UserService> ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }

        private List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3850")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }

    }
}
