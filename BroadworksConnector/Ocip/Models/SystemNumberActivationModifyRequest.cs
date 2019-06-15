using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify system number activation setting.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _useNumberActivation;

        [XmlElement(ElementName = "useNumberActivation", IsNullable = false, Namespace = "")]
        public bool UseNumberActivation {
            get => _useNumberActivation;
            set {
                UseNumberActivationSpecified = true;
                _useNumberActivation = value;
            }
        }

        [XmlIgnore]
        public bool UseNumberActivationSpecified { get; set; }
        
    }
}
