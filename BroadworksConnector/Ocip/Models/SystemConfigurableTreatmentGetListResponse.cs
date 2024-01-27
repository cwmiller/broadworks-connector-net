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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6844""}]")]
    public class SystemConfigurableTreatmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _treatmentTable;

        [XmlElement(ElementName = "treatmentTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:6844")]
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
