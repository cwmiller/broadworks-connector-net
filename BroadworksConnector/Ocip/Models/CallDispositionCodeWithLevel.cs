using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a Call Center Call Disposition Code and its Level
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallDispositionCodeWithLevel 
    {

        
        private string _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        public string Code {
            get => _code;
            set {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        public bool CodeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallDispositionCodeLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallDispositionCodeLevel Level {
            get => _level;
            set {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        public bool LevelSpecified { get; set; }
        
    }
}
