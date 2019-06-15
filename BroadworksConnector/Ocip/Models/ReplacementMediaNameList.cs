using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of media that replaces a previously configured list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementMediaNameList 
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
