using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Resource Priority settings of a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1eceb69ac1f6f751a3ee0dce729e5cc2:181""}]")]
    public class UserResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:181")]
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

        protected bool _useDefaultResourcePriority;

        [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:181")]
        public bool UseDefaultResourcePriority
        {
            get => _useDefaultResourcePriority;
            set
            {
                UseDefaultResourcePrioritySpecified = true;
                _useDefaultResourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool UseDefaultResourcePrioritySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

        [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:181")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority
        {
            get => _userResourcePriority;
            set
            {
                UserResourcePrioritySpecified = true;
                _userResourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool UserResourcePrioritySpecified { get; set; }

    }
}
