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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0c61aa8506194ca714d0fe1c4a0b57ff:163""}]")]
    public class UserResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useDefaultResourcePriority;

        [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:163")]
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
        public bool UseDefaultResourcePrioritySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _defaultResourcePriority;

        [XmlElement(ElementName = "defaultResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:163")]
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
        public bool DefaultResourcePrioritySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

        [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:163")]
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
        public bool UserResourcePrioritySpecified { get; set; }

    }
}
