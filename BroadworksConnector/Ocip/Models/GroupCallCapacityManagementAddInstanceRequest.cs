using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds a Call Capacity Management group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dfcd2b22f2e2b3540d286342087ce042:50""}]")]
    public class GroupCallCapacityManagementAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
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
        public bool GroupIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
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
        public bool NameSpecified { get; set; }

        private int _maxActiveCallsAllowed;

        [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
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
        public bool MaxActiveCallsAllowedSpecified { get; set; }

        private int _maxIncomingActiveCallsAllowed;

        [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
        [MinInclusive(0)]
        [MaxInclusive(99999)]
        public int MaxIncomingActiveCallsAllowed
        {
            get => _maxIncomingActiveCallsAllowed;
            set
            {
                MaxIncomingActiveCallsAllowedSpecified = true;
                _maxIncomingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        public bool MaxIncomingActiveCallsAllowedSpecified { get; set; }

        private int _maxOutgoingActiveCallsAllowed;

        [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
        [MinInclusive(0)]
        [MaxInclusive(99999)]
        public int MaxOutgoingActiveCallsAllowed
        {
            get => _maxOutgoingActiveCallsAllowed;
            set
            {
                MaxOutgoingActiveCallsAllowedSpecified = true;
                _maxOutgoingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        public bool MaxOutgoingActiveCallsAllowedSpecified { get; set; }

        private bool _becomeDefaultGroupForNewUsers;

        [XmlElement(ElementName = "becomeDefaultGroupForNewUsers", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
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
        public bool BecomeDefaultGroupForNewUsersSpecified { get; set; }

        private List<string> _userId = new List<string>();

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:50")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> UserId
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

    }
}
