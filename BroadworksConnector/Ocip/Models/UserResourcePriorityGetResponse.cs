using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserResourcePriorityGetRequest.
    /// Contains the Resource Priority settings of a user.
    /// If useDefaultResourcePriority is true, parameter resourcePriority will not be returned.
    /// <see cref="UserResourcePriorityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1eceb69ac1f6f751a3ee0dce729e5cc2:163""}]")]
    public class UserResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useDefaultResourcePriority;

        [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:163")]
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

        protected BroadWorksConnector.Ocip.Models.ResourcePriorityValue _defaultResourcePriority;

        [XmlElement(ElementName = "defaultResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:163")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue DefaultResourcePriority
        {
            get => _defaultResourcePriority;
            set
            {
                DefaultResourcePrioritySpecified = true;
                _defaultResourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultResourcePrioritySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

        [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:163")]
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
