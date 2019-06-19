using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system number portability status information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12077""}]")]
    public class SystemNumberPortabilityQueryStatusAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12077")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

        private string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12077")]
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
        public bool TreatmentFileNameSpecified { get; set; }

    }
}
