using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDnGetUtilizationRequest.
    /// Replaced By: SystemDnGetUtilizationResponse14sp3
    /// <see cref="SystemDnGetUtilizationRequest"/>
    /// <see cref="SystemDnGetUtilizationResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5135""}]")]
    public class SystemDnGetUtilizationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5135")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5135")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5135")]
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

        private BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5135")]
        public BroadWorksConnector.Ocip.Models.UserType UserType
        {
            get => _userType;
            set
            {
                UserTypeSpecified = true;
                _userType = value;
            }
        }

        [XmlIgnore]
        protected bool UserTypeSpecified { get; set; }

        private bool _isGroupCallingLineId;

        [XmlElement(ElementName = "isGroupCallingLineId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5135")]
        public bool IsGroupCallingLineId
        {
            get => _isGroupCallingLineId;
            set
            {
                IsGroupCallingLineIdSpecified = true;
                _isGroupCallingLineId = value;
            }
        }

        [XmlIgnore]
        protected bool IsGroupCallingLineIdSpecified { get; set; }

    }
}
