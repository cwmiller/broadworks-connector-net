using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemConfigurableTreatmentGetListRequest. Contains a table with one row per treatment.
    /// The table columns are: "Treatment Id", "Description".
    /// <see cref="SystemConfigurableTreatmentGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6755""}]")]
    public class SystemConfigurableTreatmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentTable;

        [XmlElement(ElementName = "treatmentTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6755")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentTable
        {
            get => _treatmentTable;
            set
            {
                TreatmentTableSpecified = true;
                _treatmentTable = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentTableSpecified { get; set; }

    }
}
