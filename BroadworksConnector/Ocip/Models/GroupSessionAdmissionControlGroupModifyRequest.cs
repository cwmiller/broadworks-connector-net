using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a session admission control group for the group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Note that to provision the accessInfoPattern element, the
    /// captureAccessInfoInPaniHeader system parameter needs to be set to "true".
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7197""}]")]
    public class GroupSessionAdmissionControlGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinLength(1)]
        [MaxLength(40)]
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

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinLength(1)]
        [MaxLength(40)]
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
        public bool NewNameSpecified { get; set; }

        private int _maxSession;

        [XmlElement(ElementName = "maxSession", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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

        private int? _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinInclusive(0)]
        public int? MaxUserOriginatingSessions
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

        private int? _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinInclusive(0)]
        public int? MaxUserTerminatingSessions
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
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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

        private int? _reservedUserOriginatingSessions;

        [XmlElement(ElementName = "reservedUserOriginatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinInclusive(0)]
        public int? ReservedUserOriginatingSessions
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

        private int? _reservedUserTerminatingSessions;

        [XmlElement(ElementName = "reservedUserTerminatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinInclusive(0)]
        public int? ReservedUserTerminatingSessions
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

        private bool _becomeDefaultGroup;

        [XmlElement(ElementName = "becomeDefaultGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        public bool BecomeDefaultGroup
        {
            get => _becomeDefaultGroup;
            set
            {
                BecomeDefaultGroupSpecified = true;
                _becomeDefaultGroup = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultGroupSpecified { get; set; }

        private bool _countIntraSACGroupSessions;

        [XmlElement(ElementName = "countIntraSACGroupSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementDeviceList _deviceList;

        [XmlElement(ElementName = "deviceList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        public BroadWorksConnector.Ocip.Models.ReplacementDeviceList DeviceList
        {
            get => _deviceList;
            set
            {
                DeviceListSpecified = true;
                _deviceList = value;
            }
        }

        [XmlIgnore]
        public bool DeviceListSpecified { get; set; }

        private bool _blockEmergencyAndRepairCallsDueToSACLimits;

        [XmlElement(ElementName = "blockEmergencyAndRepairCallsDueToSACLimits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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

        [XmlElement(ElementName = "mediaGroupName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
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

        private string _accessInfoPattern;

        [XmlElement(ElementName = "accessInfoPattern", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7197")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string AccessInfoPattern
        {
            get => _accessInfoPattern;
            set
            {
                AccessInfoPatternSpecified = true;
                _accessInfoPattern = value;
            }
        }

        [XmlIgnore]
        public bool AccessInfoPatternSpecified { get; set; }

    }
}
