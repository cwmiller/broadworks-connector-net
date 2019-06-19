using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNumberActivationGetRequest18sp1.
    /// Contains the system number activation setting.
    /// <see cref="SystemNumberActivationGetRequest18sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3279""}]")]
    public class SystemNumberActivationGetResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

        [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3279")]
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
        public bool NumberActivationModeSpecified { get; set; }

    }
}
