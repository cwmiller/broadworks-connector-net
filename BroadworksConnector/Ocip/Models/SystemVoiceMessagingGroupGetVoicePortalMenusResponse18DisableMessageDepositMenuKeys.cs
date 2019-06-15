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
     
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18DisableMessageDepositMenuKeys 
    {

        
        private string _disconnectAfterGreeting;

        [XmlElement(ElementName = "disconnectAfterGreeting", IsNullable = false, Namespace = "")]
        public string DisconnectAfterGreeting {
            get => _disconnectAfterGreeting;
            set {
                DisconnectAfterGreetingSpecified = true;
                _disconnectAfterGreeting = value;
            }
        }

        [XmlIgnore]
        public bool DisconnectAfterGreetingSpecified { get; set; }
        
        private string _forwardAfterGreeting;

        [XmlElement(ElementName = "forwardAfterGreeting", IsNullable = false, Namespace = "")]
        public string ForwardAfterGreeting {
            get => _forwardAfterGreeting;
            set {
                ForwardAfterGreetingSpecified = true;
                _forwardAfterGreeting = value;
            }
        }

        [XmlIgnore]
        public bool ForwardAfterGreetingSpecified { get; set; }
        
        private string _changeForwardingDestination;

        [XmlElement(ElementName = "changeForwardingDestination", IsNullable = false, Namespace = "")]
        public string ChangeForwardingDestination {
            get => _changeForwardingDestination;
            set {
                ChangeForwardingDestinationSpecified = true;
                _changeForwardingDestination = value;
            }
        }

        [XmlIgnore]
        public bool ChangeForwardingDestinationSpecified { get; set; }
        
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
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
