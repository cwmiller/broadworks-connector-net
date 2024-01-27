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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10875""}]")]
    public class SystemNumberActivationGetResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

        [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10875")]
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

    }
}
