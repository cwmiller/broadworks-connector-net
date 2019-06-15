using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a Media from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        public string MediaName {
            get => _mediaName;
            set {
                MediaNameSpecified = true;
                _mediaName = value;
            }
        }

        [XmlIgnore]
        public bool MediaNameSpecified { get; set; }
        
    }
}
