using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingCallBlockingServiceGetListRequest. Contains a table with one row per mapping.
    /// The table columns are: "Service", "Treatment Id".
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1 in AS data mode
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:15889""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

        [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:15889")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentMappingTable
        {
            get => _treatmentMappingTable;
            set
            {
                TreatmentMappingTableSpecified = true;
                _treatmentMappingTable = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentMappingTableSpecified { get; set; }

    }
}
