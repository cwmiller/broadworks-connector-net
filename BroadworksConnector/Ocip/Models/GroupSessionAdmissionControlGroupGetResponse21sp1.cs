using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupSessionAdmissionControlGroupGetRequest21sp1.
    /// Returns the profile information for the session admission control group.
    /// <see cref="GroupSessionAdmissionControlGroupGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2058""}]")]
    public class GroupSessionAdmissionControlGroupGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxSession;

        [XmlElement(ElementName = "maxSession", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int MaxSession
        {
            get => _maxSession;
            set
            {
                MaxSessionSpecified = true;
                _maxSession = value;
            }
        }

        [XmlIgnore]
        public bool MaxSessionSpecified { get; set; }

        private int _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int MaxUserOriginatingSessions
        {
            get => _maxUserOriginatingSessions;
            set
            {
                MaxUserOriginatingSessionsSpecified = true;
                _maxUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserOriginatingSessionsSpecified { get; set; }

        private int _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int MaxUserTerminatingSessions
        {
            get => _maxUserTerminatingSessions;
            set
            {
                MaxUserTerminatingSessionsSpecified = true;
                _maxUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserTerminatingSessionsSpecified { get; set; }

        private int _reservedSession;

        [XmlElement(ElementName = "reservedSession", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int ReservedSession
        {
            get => _reservedSession;
            set
            {
                ReservedSessionSpecified = true;
                _reservedSession = value;
            }
        }

        [XmlIgnore]
        public bool ReservedSessionSpecified { get; set; }

        private int _reservedUserOriginatingSessions;

        [XmlElement(ElementName = "reservedUserOriginatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int ReservedUserOriginatingSessions
        {
            get => _reservedUserOriginatingSessions;
            set
            {
                ReservedUserOriginatingSessionsSpecified = true;
                _reservedUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool ReservedUserOriginatingSessionsSpecified { get; set; }

        private int _reservedUserTerminatingSessions;

        [XmlElement(ElementName = "reservedUserTerminatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinInclusive(0)]
        public int ReservedUserTerminatingSessions
        {
            get => _reservedUserTerminatingSessions;
            set
            {
                ReservedUserTerminatingSessionsSpecified = true;
                _reservedUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool ReservedUserTerminatingSessionsSpecified { get; set; }

        private bool _defaultGroup;

        [XmlElement(ElementName = "defaultGroup", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        public bool DefaultGroup
        {
            get => _defaultGroup;
            set
            {
                DefaultGroupSpecified = true;
                _defaultGroup = value;
            }
        }

        [XmlIgnore]
        public bool DefaultGroupSpecified { get; set; }

        private bool _countIntraSACGroupSessions;

        [XmlElement(ElementName = "countIntraSACGroupSessions", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        public bool CountIntraSACGroupSessions
        {
            get => _countIntraSACGroupSessions;
            set
            {
                CountIntraSACGroupSessionsSpecified = true;
                _countIntraSACGroupSessions = value;
            }
        }

        [XmlIgnore]
        public bool CountIntraSACGroupSessionsSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.AccessDevice> _devices = new List<BroadWorksConnector.Ocip.Models.AccessDevice>();

        [XmlElement(ElementName = "devices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        public List<BroadWorksConnector.Ocip.Models.AccessDevice> Devices
        {
            get => _devices;
            set
            {
                DevicesSpecified = true;
                _devices = value;
            }
        }

        [XmlIgnore]
        public bool DevicesSpecified { get; set; }

        private bool _blockEmergencyAndRepairCallsDueToSACLimits;

        [XmlElement(ElementName = "blockEmergencyAndRepairCallsDueToSACLimits", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        public bool BlockEmergencyAndRepairCallsDueToSACLimits
        {
            get => _blockEmergencyAndRepairCallsDueToSACLimits;
            set
            {
                BlockEmergencyAndRepairCallsDueToSACLimitsSpecified = true;
                _blockEmergencyAndRepairCallsDueToSACLimits = value;
            }
        }

        [XmlIgnore]
        public bool BlockEmergencyAndRepairCallsDueToSACLimitsSpecified { get; set; }

        private string _mediaGroupName;

        [XmlElement(ElementName = "mediaGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2058")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MediaGroupName
        {
            get => _mediaGroupName;
            set
            {
                MediaGroupNameSpecified = true;
                _mediaGroupName = value;
            }
        }

        [XmlIgnore]
        public bool MediaGroupNameSpecified { get; set; }

    }
}
