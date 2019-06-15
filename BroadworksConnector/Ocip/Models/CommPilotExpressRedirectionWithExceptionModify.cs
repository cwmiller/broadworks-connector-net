using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express type to transfer to voice mail or forward to a number
    /// with certain exceptions used in the context of a modify.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommPilotExpressRedirectionWithExceptionModify 
    {

        
        private bool _sendCallsToVoiceMailExceptExcludedNumbers;

        [XmlElement(ElementName = "sendCallsToVoiceMailExceptExcludedNumbers", IsNullable = false, Namespace = "")]
        public bool SendCallsToVoiceMailExceptExcludedNumbers {
            get => _sendCallsToVoiceMailExceptExcludedNumbers;
            set {
                SendCallsToVoiceMailExceptExcludedNumbersSpecified = true;
                _sendCallsToVoiceMailExceptExcludedNumbers = value;
            }
        }

        [XmlIgnore]
        public bool SendCallsToVoiceMailExceptExcludedNumbersSpecified { get; set; }
        
        private string _excludedPhoneNumber01;

        [XmlElement(ElementName = "excludedPhoneNumber01", IsNullable = true, Namespace = "")]
        public string ExcludedPhoneNumber01 {
            get => _excludedPhoneNumber01;
            set {
                ExcludedPhoneNumber01Specified = true;
                _excludedPhoneNumber01 = value;
            }
        }

        [XmlIgnore]
        public bool ExcludedPhoneNumber01Specified { get; set; }
        
        private string _excludedPhoneNumber02;

        [XmlElement(ElementName = "excludedPhoneNumber02", IsNullable = true, Namespace = "")]
        public string ExcludedPhoneNumber02 {
            get => _excludedPhoneNumber02;
            set {
                ExcludedPhoneNumber02Specified = true;
                _excludedPhoneNumber02 = value;
            }
        }

        [XmlIgnore]
        public bool ExcludedPhoneNumber02Specified { get; set; }
        
        private string _excludedPhoneNumber03;

        [XmlElement(ElementName = "excludedPhoneNumber03", IsNullable = true, Namespace = "")]
        public string ExcludedPhoneNumber03 {
            get => _excludedPhoneNumber03;
            set {
                ExcludedPhoneNumber03Specified = true;
                _excludedPhoneNumber03 = value;
            }
        }

        [XmlIgnore]
        public bool ExcludedPhoneNumber03Specified { get; set; }
        
        private string _forwardExcludedNumbersTo;

        [XmlElement(ElementName = "forwardExcludedNumbersTo", IsNullable = true, Namespace = "")]
        public string ForwardExcludedNumbersTo {
            get => _forwardExcludedNumbersTo;
            set {
                ForwardExcludedNumbersToSpecified = true;
                _forwardExcludedNumbersTo = value;
            }
        }

        [XmlIgnore]
        public bool ForwardExcludedNumbersToSpecified { get; set; }
        
    }
}
