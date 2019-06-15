using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Class Mark to system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClassmarkAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        public string Classmark {
            get => _classmark;
            set {
                ClassmarkSpecified = true;
                _classmark = value;
            }
        }

        [XmlIgnore]
        public bool ClassmarkSpecified { get; set; }
        
        private string _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        public string Value {
            get => _value;
            set {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        public bool ValueSpecified { get; set; }
        
        private string _webDisplayKey;

        [XmlElement(ElementName = "webDisplayKey", IsNullable = false, Namespace = "")]
        public string WebDisplayKey {
            get => _webDisplayKey;
            set {
                WebDisplayKeySpecified = true;
                _webDisplayKey = value;
            }
        }

        [XmlIgnore]
        public bool WebDisplayKeySpecified { get; set; }
        
    }
}
