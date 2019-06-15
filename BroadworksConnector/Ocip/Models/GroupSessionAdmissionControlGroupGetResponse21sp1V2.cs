using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupSessionAdmissionControlGroupGetRequest21sp1V2.
    /// Returns the profile information for the session admission control group.
        /// <see cref="GroupSessionAdmissionControlGroupGetRequest21sp1V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupSessionAdmissionControlGroupGetResponse21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _maxSession;

        [XmlElement(ElementName = "maxSession", IsNullable = false, Namespace = "")]
        public int MaxSession {
            get => _maxSession;
            set {
                MaxSessionSpecified = true;
                _maxSession = value;
            }
        }

        [XmlIgnore]
        public bool MaxSessionSpecified { get; set; }
        
        private int _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false, Namespace = "")]
        public int MaxUserOriginatingSessions {
            get => _maxUserOriginatingSessions;
            set {
                MaxUserOriginatingSessionsSpecified = true;
                _maxUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserOriginatingSessionsSpecified { get; set; }
        
        private int _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false, Namespace = "")]
        public int MaxUserTerminatingSessions {
            get => _maxUserTerminatingSessions;
            set {
                MaxUserTerminatingSessionsSpecified = true;
                _maxUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserTerminatingSessionsSpecified { get; set; }
        
        private int _reservedSession;

        [XmlElement(ElementName = "reservedSession", IsNullable = false, Namespace = "")]
        public int ReservedSession {
            get => _reservedSession;
            set {
                ReservedSessionSpecified = true;
                _reservedSession = value;
            }
        }

        [XmlIgnore]
        public bool ReservedSessionSpecified { get; set; }
        
        private int _reservedUserOriginatingSessions;

        [XmlElement(ElementName = "reservedUserOriginatingSessions", IsNullable = false, Namespace = "")]
        public int ReservedUserOriginatingSessions {
            get => _reservedUserOriginatingSessions;
            set {
                ReservedUserOriginatingSessionsSpecified = true;
                _reservedUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool ReservedUserOriginatingSessionsSpecified { get; set; }
        
        private int _reservedUserTerminatingSessions;

        [XmlElement(ElementName = "reservedUserTerminatingSessions", IsNullable = false, Namespace = "")]
        public int ReservedUserTerminatingSessions {
            get => _reservedUserTerminatingSessions;
            set {
                ReservedUserTerminatingSessionsSpecified = true;
                _reservedUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool ReservedUserTerminatingSessionsSpecified { get; set; }
        
        private bool _defaultGroup;

        [XmlElement(ElementName = "defaultGroup", IsNullable = false, Namespace = "")]
        public bool DefaultGroup {
            get => _defaultGroup;
            set {
                DefaultGroupSpecified = true;
                _defaultGroup = value;
            }
        }

        [XmlIgnore]
        public bool DefaultGroupSpecified { get; set; }
        
        private bool _countIntraSACGroupSessions;

        [XmlElement(ElementName = "countIntraSACGroupSessions", IsNullable = false, Namespace = "")]
        public bool CountIntraSACGroupSessions {
            get => _countIntraSACGroupSessions;
            set {
                CountIntraSACGroupSessionsSpecified = true;
                _countIntraSACGroupSessions = value;
            }
        }

        [XmlIgnore]
        public bool CountIntraSACGroupSessionsSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.AccessDevice> _devices;

        [XmlElement(ElementName = "devices", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AccessDevice> Devices {
            get => _devices;
            set {
                DevicesSpecified = true;
                _devices = value;
            }
        }

        [XmlIgnore]
        public bool DevicesSpecified { get; set; }
        
        private bool _blockEmergencyAndRepairCallsDueToSACLimits;

        [XmlElement(ElementName = "blockEmergencyAndRepairCallsDueToSACLimits", IsNullable = false, Namespace = "")]
        public bool BlockEmergencyAndRepairCallsDueToSACLimits {
            get => _blockEmergencyAndRepairCallsDueToSACLimits;
            set {
                BlockEmergencyAndRepairCallsDueToSACLimitsSpecified = true;
                _blockEmergencyAndRepairCallsDueToSACLimits = value;
            }
        }

        [XmlIgnore]
        public bool BlockEmergencyAndRepairCallsDueToSACLimitsSpecified { get; set; }
        
        private string _mediaGroupName;

        [XmlElement(ElementName = "mediaGroupName", IsNullable = false, Namespace = "")]
        public string MediaGroupName {
            get => _mediaGroupName;
            set {
                MediaGroupNameSpecified = true;
                _mediaGroupName = value;
            }
        }

        [XmlIgnore]
        public bool MediaGroupNameSpecified { get; set; }
        
        private string _accessInfoPattern;

        [XmlElement(ElementName = "accessInfoPattern", IsNullable = false, Namespace = "")]
        public string AccessInfoPattern {
            get => _accessInfoPattern;
            set {
                AccessInfoPatternSpecified = true;
                _accessInfoPattern = value;
            }
        }

        [XmlIgnore]
        public bool AccessInfoPatternSpecified { get; set; }
        
    }
}
