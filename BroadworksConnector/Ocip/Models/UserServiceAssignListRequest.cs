using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to assign the user services and service packs for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// In AS data mode, a Warning ErrorResponse is sent when the transaction is partially successful
    /// while an Error ErrorResponse is sent when the transaction fails for all the services.
    /// In XS data mode, a Warning ErrorResponse is always sent when there is at least one error.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3856""}]")]
    public class UserServiceAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3856")]
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

        protected List<BroadWorksConnector.Ocip.Models.UserService> _serviceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3856")]
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
        protected bool ServiceNameSpecified { get; set; }

        protected List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3856")]
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
        protected bool ServicePackNameSpecified { get; set; }

    }
}
