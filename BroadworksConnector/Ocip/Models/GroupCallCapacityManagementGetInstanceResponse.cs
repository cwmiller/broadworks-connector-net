using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCapacityManagementGetInstanceRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupCallCapacityManagementGetInstanceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dfcd2b22f2e2b3540d286342087ce042:225""}]")]
    public class GroupCallCapacityManagementGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
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

        private int _maxActiveCallsAllowed;

        [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
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

        private int _maxIncomingActiveCallsAllowed;

        [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
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
        protected bool MaxIncomingActiveCallsAllowedSpecified { get; set; }

        private int _maxOutgoingActiveCallsAllowed;

        [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
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
        protected bool MaxOutgoingActiveCallsAllowedSpecified { get; set; }

        private bool _defaultGroupForNewUsers;

        [XmlElement(ElementName = "defaultGroupForNewUsers", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
        public bool DefaultGroupForNewUsers
        {
            get => _defaultGroupForNewUsers;
            set
            {
                DefaultGroupForNewUsersSpecified = true;
                _defaultGroupForNewUsers = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultGroupForNewUsersSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"dfcd2b22f2e2b3540d286342087ce042:225")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}
