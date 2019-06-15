using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCallForwardingOptionsMenuKeys 
    {

        
        private string _activateCallForwarding;

        [XmlElement(ElementName = "activateCallForwarding", IsNullable = true, Namespace = "")]
        public string ActivateCallForwarding {
            get => _activateCallForwarding;
            set {
                ActivateCallForwardingSpecified = true;
                _activateCallForwarding = value;
            }
        }

        [XmlIgnore]
        public bool ActivateCallForwardingSpecified { get; set; }
        
        private string _deactivateCallForwarding;

        [XmlElement(ElementName = "deactivateCallForwarding", IsNullable = true, Namespace = "")]
        public string DeactivateCallForwarding {
            get => _deactivateCallForwarding;
            set {
                DeactivateCallForwardingSpecified = true;
                _deactivateCallForwarding = value;
            }
        }

        [XmlIgnore]
        public bool DeactivateCallForwardingSpecified { get; set; }
        
        private string _changeCallForwardingDestination;

        [XmlElement(ElementName = "changeCallForwardingDestination", IsNullable = true, Namespace = "")]
        public string ChangeCallForwardingDestination {
            get => _changeCallForwardingDestination;
            set {
                ChangeCallForwardingDestinationSpecified = true;
                _changeCallForwardingDestination = value;
            }
        }

        [XmlIgnore]
        public bool ChangeCallForwardingDestinationSpecified { get; set; }
        
        private string _listenToCallForwardingStatus;

        [XmlElement(ElementName = "listenToCallForwardingStatus", IsNullable = true, Namespace = "")]
        public string ListenToCallForwardingStatus {
            get => _listenToCallForwardingStatus;
            set {
                ListenToCallForwardingStatusSpecified = true;
                _listenToCallForwardingStatus = value;
            }
        }

        [XmlIgnore]
        public bool ListenToCallForwardingStatusSpecified { get; set; }
        
        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        public string ReturnToPreviousMenu {
            get => _returnToPreviousMenu;
            set {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool ReturnToPreviousMenuSpecified { get; set; }
        
        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        public string RepeatMenu {
            get => _repeatMenu;
            set {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        public bool RepeatMenuSpecified { get; set; }
        
    }
}
