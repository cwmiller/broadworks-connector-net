using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Notify.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallNotifyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        public string DefaultFromAddress {
            get => _defaultFromAddress;
            set {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }
        
        private bool _useShortSubjectLine;

        [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
        public bool UseShortSubjectLine {
            get => _useShortSubjectLine;
            set {
                UseShortSubjectLineSpecified = true;
                _useShortSubjectLine = value;
            }
        }

        [XmlIgnore]
        public bool UseShortSubjectLineSpecified { get; set; }
        
        private bool _useDnInMailBody;

        [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
        public bool UseDnInMailBody {
            get => _useDnInMailBody;
            set {
                UseDnInMailBodySpecified = true;
                _useDnInMailBody = value;
            }
        }

        [XmlIgnore]
        public bool UseDnInMailBodySpecified { get; set; }
        
    }
}
