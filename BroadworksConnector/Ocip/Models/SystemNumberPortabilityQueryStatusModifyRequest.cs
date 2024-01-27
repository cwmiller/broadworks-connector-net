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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13470""}]")]
    public class SystemNumberPortabilityQueryStatusModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _statusName;

        [XmlElement(ElementName = "statusName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13470")]
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

        protected string _newStatusName;

        [XmlElement(ElementName = "newStatusName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13470")]
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

        protected string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13470")]
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
