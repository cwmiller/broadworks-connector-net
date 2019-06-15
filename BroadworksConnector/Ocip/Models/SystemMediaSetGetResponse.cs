using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaSetGetRequest.
    /// Returns a list of media names in the set.
        /// <see cref="SystemMediaSetGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
