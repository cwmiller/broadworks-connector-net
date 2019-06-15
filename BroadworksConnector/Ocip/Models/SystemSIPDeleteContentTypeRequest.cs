using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a content type for the SIP interface.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeleteContentTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
