using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemInCallServiceActivationGetRequest.
    /// Replaced by: SystemInCallServiceActivationGetResponse17
        /// <see cref="SystemInCallServiceActivationGetRequest"/>
        /// <see cref="SystemInCallServiceActivationGetResponse17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInCallServiceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _defaultActivationDigits;

        [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
        public string DefaultActivationDigits {
            get => _defaultActivationDigits;
            set {
                DefaultActivationDigitsSpecified = true;
                _defaultActivationDigits = value;
            }
        }

        [XmlIgnore]
        public bool DefaultActivationDigitsSpecified { get; set; }
        
    }
}
