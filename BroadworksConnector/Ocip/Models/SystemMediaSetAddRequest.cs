using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a Media Set.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaSetAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        public string SetName {
            get => _setName;
            set {
                SetNameSpecified = true;
                _setName = value;
            }
        }

        [XmlIgnore]
        public bool SetNameSpecified { get; set; }
        
        private List<string> _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        public List<string> MediaName {
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
