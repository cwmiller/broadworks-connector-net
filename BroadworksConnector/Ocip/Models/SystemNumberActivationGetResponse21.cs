using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNumberActivationGetRequest21.
    /// Contains the system number activation and enterprise trunk number range activation setting.
    /// <see cref="SystemNumberActivationGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12957""}]")]
    public class SystemNumberActivationGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

        [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12957")]
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

        protected bool _enableEnterpriseTrunkNumberRangeActivation;

        [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12957")]
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
