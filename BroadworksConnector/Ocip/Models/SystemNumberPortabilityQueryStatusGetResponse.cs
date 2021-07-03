using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryStatusGetRequest.
    /// <see cref="SystemNumberPortabilityQueryStatusGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13284""}]")]
    public class SystemNumberPortabilityQueryStatusGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13284")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TreatmentFileName
        {
            get => _treatmentFileName;
            set
            {
                TreatmentFileNameSpecified = true;
                _treatmentFileName = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentFileNameSpecified { get; set; }

    }
}
