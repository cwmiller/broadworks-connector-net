using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify system number activation and enterprise trunk number range activation setting.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following element values are only applicable in AS data mode:
    /// enableEnterpriseTrunkNumberRangeActivation
    /// numberActivationMode = Group And User Activation Enabled will raise an error in XS data mode.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberActivationModifyRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

        [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.NumberActivationMode NumberActivationMode {
            get => _numberActivationMode;
            set {
                NumberActivationModeSpecified = true;
                _numberActivationMode = value;
            }
        }

        [XmlIgnore]
        public bool NumberActivationModeSpecified { get; set; }
        
        private bool _enableEnterpriseTrunkNumberRangeActivation;

        [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false, Namespace = "")]
        public bool EnableEnterpriseTrunkNumberRangeActivation {
            get => _enableEnterpriseTrunkNumberRangeActivation;
            set {
                EnableEnterpriseTrunkNumberRangeActivationSpecified = true;
                _enableEnterpriseTrunkNumberRangeActivation = value;
            }
        }

        [XmlIgnore]
        public bool EnableEnterpriseTrunkNumberRangeActivationSpecified { get; set; }
        
    }
}
