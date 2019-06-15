using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's commPilot express service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCommPilotExpressModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressProfile? _profile;

        [XmlElement(ElementName = "profile", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressProfile? Profile {
            get => _profile;
            set {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        public bool ProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify _availableInOffice;

        [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify AvailableInOffice {
            get => _availableInOffice;
            set {
                AvailableInOfficeSpecified = true;
                _availableInOffice = value;
            }
        }

        [XmlIgnore]
        public bool AvailableInOfficeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify _availableOutOfOffice;

        [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify AvailableOutOfOffice {
            get => _availableOutOfOffice;
            set {
                AvailableOutOfOfficeSpecified = true;
                _availableOutOfOffice = value;
            }
        }

        [XmlIgnore]
        public bool AvailableOutOfOfficeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressBusyModify _busy;

        [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressBusyModify Busy {
            get => _busy;
            set {
                BusySpecified = true;
                _busy = value;
            }
        }

        [XmlIgnore]
        public bool BusySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailableModify _unavailable;

        [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailableModify Unavailable {
            get => _unavailable;
            set {
                UnavailableSpecified = true;
                _unavailable = value;
            }
        }

        [XmlIgnore]
        public bool UnavailableSpecified { get; set; }
        
    }
}
