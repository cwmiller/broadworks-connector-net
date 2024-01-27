using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNumberActivationGetRequest.
    /// Contains the system number activation setting.
    /// <see cref="SystemNumberActivationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28520""}]")]
    public class SystemNumberActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useNumberActivation;

        [XmlElement(ElementName = "useNumberActivation", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28520")]
        public bool UseNumberActivation
        {
            get => _useNumberActivation;
            set
            {
                UseNumberActivationSpecified = true;
                _useNumberActivation = value;
            }
        }

        [XmlIgnore]
        protected bool UseNumberActivationSpecified { get; set; }

    }
}
