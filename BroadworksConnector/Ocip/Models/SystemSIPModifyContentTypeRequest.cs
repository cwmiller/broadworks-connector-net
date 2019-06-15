using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an content type for the SIP interface.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPModifyContentTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _contentType;

        [XmlElement(ElementName = "contentType", IsNullable = false, Namespace = "")]
        public string ContentType {
            get => _contentType;
            set {
                ContentTypeSpecified = true;
                _contentType = value;
            }
        }

        [XmlIgnore]
        public bool ContentTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemSIPSupportedInterface _interface;

        [XmlElement(ElementName = "interface", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemSIPSupportedInterface Interface {
            get => _interface;
            set {
                InterfaceSpecified = true;
                _interface = value;
            }
        }

        [XmlIgnore]
        public bool InterfaceSpecified { get; set; }
        
    }
}
