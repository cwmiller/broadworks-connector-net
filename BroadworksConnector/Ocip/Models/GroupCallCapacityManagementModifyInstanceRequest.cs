using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies a Call Capacity Management group. Replaces the entire list of users in the group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7e3b48428e45d35b1edd744adc90f9b:246""}]")]
    public class GroupCallCapacityManagementModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
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

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        protected int _maxActiveCallsAllowed;

        [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        [MinInclusive(0)]
        [MaxInclusive(99999)]
        public int MaxActiveCallsAllowed
        {
            get => _maxActiveCallsAllowed;
            set
            {
                MaxActiveCallsAllowedSpecified = true;
                _maxActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool MaxActiveCallsAllowedSpecified { get; set; }

        protected int? _maxIncomingActiveCallsAllowed;

        [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        [MinInclusive(0)]
        [MaxInclusive(99999)]
        public int? MaxIncomingActiveCallsAllowed
        {
            get => _maxIncomingActiveCallsAllowed;
            set
            {
                MaxIncomingActiveCallsAllowedSpecified = true;
                _maxIncomingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool MaxIncomingActiveCallsAllowedSpecified { get; set; }

        protected int? _maxOutgoingActiveCallsAllowed;

        [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        [MinInclusive(0)]
        [MaxInclusive(99999)]
        public int? MaxOutgoingActiveCallsAllowed
        {
            get => _maxOutgoingActiveCallsAllowed;
            set
            {
                MaxOutgoingActiveCallsAllowedSpecified = true;
                _maxOutgoingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool MaxOutgoingActiveCallsAllowedSpecified { get; set; }

        protected bool _becomeDefaultGroupForNewUsers;

        [XmlElement(ElementName = "becomeDefaultGroupForNewUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        public bool BecomeDefaultGroupForNewUsers
        {
            get => _becomeDefaultGroupForNewUsers;
            set
            {
                BecomeDefaultGroupForNewUsersSpecified = true;
                _becomeDefaultGroupForNewUsers = value;
            }
        }

        [XmlIgnore]
        protected bool BecomeDefaultGroupForNewUsersSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _userIdList;

        [XmlElement(ElementName = "userIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:246")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList UserIdList
        {
            get => _userIdList;
            set
            {
                UserIdListSpecified = true;
                _userIdList = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdListSpecified { get; set; }

    }
}
