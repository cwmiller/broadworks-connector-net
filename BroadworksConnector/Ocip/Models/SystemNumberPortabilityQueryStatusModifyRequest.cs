using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system number portability status information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13300""}]")]
    public class SystemNumberPortabilityQueryStatusModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _statusName;

        [XmlElement(ElementName = "statusName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string StatusName
        {
            get => _statusName;
            set
            {
                StatusNameSpecified = true;
                _statusName = value;
            }
        }

        [XmlIgnore]
        protected bool StatusNameSpecified { get; set; }

        private string _newStatusName;

        [XmlElement(ElementName = "newStatusName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewStatusName
        {
            get => _newStatusName;
            set
            {
                NewStatusNameSpecified = true;
                _newStatusName = value;
            }
        }

        [XmlIgnore]
        protected bool NewStatusNameSpecified { get; set; }

        private string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13300")]
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
