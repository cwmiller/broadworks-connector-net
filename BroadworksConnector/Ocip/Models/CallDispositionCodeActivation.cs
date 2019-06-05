using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallDispositionCodeActivation
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
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
    }
}
