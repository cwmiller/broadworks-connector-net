using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Number Portability Query Parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _continueCallAsDialedOnTimeoutOrError;

        [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false, Namespace = "")]
        public bool ContinueCallAsDialedOnTimeoutOrError {
            get => _continueCallAsDialedOnTimeoutOrError;
            set {
                ContinueCallAsDialedOnTimeoutOrErrorSpecified = true;
                _continueCallAsDialedOnTimeoutOrError = value;
            }
        }

        [XmlIgnore]
        public bool ContinueCallAsDialedOnTimeoutOrErrorSpecified { get; set; }
        
        private int _numberPortabilityNameLookupTimeoutMilliseconds;

        [XmlElement(ElementName = "numberPortabilityNameLookupTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        public int NumberPortabilityNameLookupTimeoutMilliseconds {
            get => _numberPortabilityNameLookupTimeoutMilliseconds;
            set {
                NumberPortabilityNameLookupTimeoutMillisecondsSpecified = true;
                _numberPortabilityNameLookupTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool NumberPortabilityNameLookupTimeoutMillisecondsSpecified { get; set; }
        
    }
}
