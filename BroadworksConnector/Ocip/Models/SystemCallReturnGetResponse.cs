using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallReturnGetRequest.
        /// <see cref="SystemCallReturnGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallReturnGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _twoLevelActivation;

        [XmlElement(ElementName = "twoLevelActivation", IsNullable = false, Namespace = "")]
        public bool TwoLevelActivation {
            get => _twoLevelActivation;
            set {
                TwoLevelActivationSpecified = true;
                _twoLevelActivation = value;
            }
        }

        [XmlIgnore]
        public bool TwoLevelActivationSpecified { get; set; }
        
        private bool _provideDate;

        [XmlElement(ElementName = "provideDate", IsNullable = false, Namespace = "")]
        public bool ProvideDate {
            get => _provideDate;
            set {
                ProvideDateSpecified = true;
                _provideDate = value;
            }
        }

        [XmlIgnore]
        public bool ProvideDateSpecified { get; set; }
        
        private bool _lastUnansweredCallOnly;

        [XmlElement(ElementName = "lastUnansweredCallOnly", IsNullable = false, Namespace = "")]
        public bool LastUnansweredCallOnly {
            get => _lastUnansweredCallOnly;
            set {
                LastUnansweredCallOnlySpecified = true;
                _lastUnansweredCallOnly = value;
            }
        }

        [XmlIgnore]
        public bool LastUnansweredCallOnlySpecified { get; set; }
        
        private string _confirmationKey;

        [XmlElement(ElementName = "confirmationKey", IsNullable = false, Namespace = "")]
        public string ConfirmationKey {
            get => _confirmationKey;
            set {
                ConfirmationKeySpecified = true;
                _confirmationKey = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmationKeySpecified { get; set; }
        
        private bool _allowRestrictedNumber;

        [XmlElement(ElementName = "allowRestrictedNumber", IsNullable = false, Namespace = "")]
        public bool AllowRestrictedNumber {
            get => _allowRestrictedNumber;
            set {
                AllowRestrictedNumberSpecified = true;
                _allowRestrictedNumber = value;
            }
        }

        [XmlIgnore]
        public bool AllowRestrictedNumberSpecified { get; set; }
        
        private bool _deleteNumberAfterAnsweredCallReturn;

        [XmlElement(ElementName = "deleteNumberAfterAnsweredCallReturn", IsNullable = false, Namespace = "")]
        public bool DeleteNumberAfterAnsweredCallReturn {
            get => _deleteNumberAfterAnsweredCallReturn;
            set {
                DeleteNumberAfterAnsweredCallReturnSpecified = true;
                _deleteNumberAfterAnsweredCallReturn = value;
            }
        }

        [XmlIgnore]
        public bool DeleteNumberAfterAnsweredCallReturnSpecified { get; set; }
        
    }
}
