using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The NS treatment map entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18570""}]")]
    public class NSTreatmentMapEntry
    {

        private string _nsTreatment;

        [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18570")]
        [MinLength(1)]
        [MaxLength(8)]
        public string NsTreatment
        {
            get => _nsTreatment;
            set
            {
                NsTreatmentSpecified = true;
                _nsTreatment = value;
            }
        }

        [XmlIgnore]
        public bool NsTreatmentSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18570")]
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
        public bool TreatmentIdSpecified { get; set; }

    }
}
