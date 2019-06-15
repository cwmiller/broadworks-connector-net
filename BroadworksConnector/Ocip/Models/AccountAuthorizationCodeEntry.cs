using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Account/Authorization Code.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AccountAuthorizationCodeEntry 
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
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
