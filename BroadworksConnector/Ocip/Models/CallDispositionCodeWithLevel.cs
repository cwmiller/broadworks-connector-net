using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallDispositionCodeWithLevel
    {
        private string _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        public string Code
        {
            get => _code;
            set
            {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        public bool CodeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallDispositionCodeLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallDispositionCodeLevel Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        public bool LevelSpecified { get; set; }
    }
}
