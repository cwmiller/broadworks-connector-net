using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a session admission control group for the enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseSessionAdmissionControlGroupAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
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
        
        private bool _becomeDefaultGroup;

        [XmlElement(ElementName = "becomeDefaultGroup", IsNullable = false, Namespace = "")]
        public bool BecomeDefaultGroup {
            get => _becomeDefaultGroup;
            set {
                BecomeDefaultGroupSpecified = true;
                _becomeDefaultGroup = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultGroupSpecified { get; set; }
        
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
        
        private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _devices;

        [XmlElement(ElementName = "devices", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Devices {
            get => _devices;
            set {
                DevicesSpecified = true;
                _devices = value;
            }
        }

        [XmlIgnore]
        public bool DevicesSpecified { get; set; }
        
    }
}
