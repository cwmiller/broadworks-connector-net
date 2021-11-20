using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12978""}]")]
    public class SystemNumberActivationModifyRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

        [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12978")]
        public BroadWorksConnector.Ocip.Models.NumberActivationMode NumberActivationMode
        {
            get => _numberActivationMode;
            set
            {
                NumberActivationModeSpecified = true;
                _numberActivationMode = value;
            }
        }

        [XmlIgnore]
        protected bool NumberActivationModeSpecified { get; set; }

        private bool _enableEnterpriseTrunkNumberRangeActivation;

        [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12978")]
        public bool EnableEnterpriseTrunkNumberRangeActivation
        {
            get => _enableEnterpriseTrunkNumberRangeActivation;
            set
            {
                EnableEnterpriseTrunkNumberRangeActivationSpecified = true;
                _enableEnterpriseTrunkNumberRangeActivation = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEnterpriseTrunkNumberRangeActivationSpecified { get; set; }

    }
}
