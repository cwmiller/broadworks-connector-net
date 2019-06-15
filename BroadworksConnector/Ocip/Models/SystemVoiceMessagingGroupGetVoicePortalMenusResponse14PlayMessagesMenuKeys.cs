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
     
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14PlayMessagesMenuKeys 
    {

        
        private string _saveMessage;

        [XmlElement(ElementName = "saveMessage", IsNullable = false, Namespace = "")]
        public string SaveMessage {
            get => _saveMessage;
            set {
                SaveMessageSpecified = true;
                _saveMessage = value;
            }
        }

        [XmlIgnore]
        public bool SaveMessageSpecified { get; set; }
        
        private string _deleteMessage;

        [XmlElement(ElementName = "deleteMessage", IsNullable = false, Namespace = "")]
        public string DeleteMessage {
            get => _deleteMessage;
            set {
                DeleteMessageSpecified = true;
                _deleteMessage = value;
            }
        }

        [XmlIgnore]
        public bool DeleteMessageSpecified { get; set; }
        
        private string _playMessage;

        [XmlElement(ElementName = "playMessage", IsNullable = false, Namespace = "")]
        public string PlayMessage {
            get => _playMessage;
            set {
                PlayMessageSpecified = true;
                _playMessage = value;
            }
        }

        [XmlIgnore]
        public bool PlayMessageSpecified { get; set; }
        
        private string _previousMessage;

        [XmlElement(ElementName = "previousMessage", IsNullable = false, Namespace = "")]
        public string PreviousMessage {
            get => _previousMessage;
            set {
                PreviousMessageSpecified = true;
                _previousMessage = value;
            }
        }

        [XmlIgnore]
        public bool PreviousMessageSpecified { get; set; }
        
        private string _playEnvelope;

        [XmlElement(ElementName = "playEnvelope", IsNullable = false, Namespace = "")]
        public string PlayEnvelope {
            get => _playEnvelope;
            set {
                PlayEnvelopeSpecified = true;
                _playEnvelope = value;
            }
        }

        [XmlIgnore]
        public bool PlayEnvelopeSpecified { get; set; }
        
        private string _nextMessage;

        [XmlElement(ElementName = "nextMessage", IsNullable = false, Namespace = "")]
        public string NextMessage {
            get => _nextMessage;
            set {
                NextMessageSpecified = true;
                _nextMessage = value;
            }
        }

        [XmlIgnore]
        public bool NextMessageSpecified { get; set; }
        
        private string _callbackCaller;

        [XmlElement(ElementName = "callbackCaller", IsNullable = false, Namespace = "")]
        public string CallbackCaller {
            get => _callbackCaller;
            set {
                CallbackCallerSpecified = true;
                _callbackCaller = value;
            }
        }

        [XmlIgnore]
        public bool CallbackCallerSpecified { get; set; }
        
        private string _composeMessage;

        [XmlElement(ElementName = "composeMessage", IsNullable = false, Namespace = "")]
        public string ComposeMessage {
            get => _composeMessage;
            set {
                ComposeMessageSpecified = true;
                _composeMessage = value;
            }
        }

        [XmlIgnore]
        public bool ComposeMessageSpecified { get; set; }
        
        private string _replyMessage;

        [XmlElement(ElementName = "replyMessage", IsNullable = false, Namespace = "")]
        public string ReplyMessage {
            get => _replyMessage;
            set {
                ReplyMessageSpecified = true;
                _replyMessage = value;
            }
        }

        [XmlIgnore]
        public bool ReplyMessageSpecified { get; set; }
        
        private string _forwardMessage;

        [XmlElement(ElementName = "forwardMessage", IsNullable = false, Namespace = "")]
        public string ForwardMessage {
            get => _forwardMessage;
            set {
                ForwardMessageSpecified = true;
                _forwardMessage = value;
            }
        }

        [XmlIgnore]
        public bool ForwardMessageSpecified { get; set; }
        
        private string _additionalMessageOptions;

        [XmlElement(ElementName = "additionalMessageOptions", IsNullable = false, Namespace = "")]
        public string AdditionalMessageOptions {
            get => _additionalMessageOptions;
            set {
                AdditionalMessageOptionsSpecified = true;
                _additionalMessageOptions = value;
            }
        }

        [XmlIgnore]
        public bool AdditionalMessageOptionsSpecified { get; set; }
        
        private string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = false, Namespace = "")]
        public string PersonalizedName {
            get => _personalizedName;
            set {
                PersonalizedNameSpecified = true;
                _personalizedName = value;
            }
        }

        [XmlIgnore]
        public bool PersonalizedNameSpecified { get; set; }
        
        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        public string Passcode {
            get => _passcode;
            set {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeSpecified { get; set; }
        
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
