using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The internal release cause map entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19945""}]")]
    public class InternalReleaseCauseMapEntry
    {

        private BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

        [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19945")]
        public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause
        {
            get => _internalReleaseCause;
            set
            {
                InternalReleaseCauseSpecified = true;
                _internalReleaseCause = value;
            }
        }

        [XmlIgnore]
        protected bool InternalReleaseCauseSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19945")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

    }
}
