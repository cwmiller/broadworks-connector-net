using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingNetworkSIPStatusGetListRequest. Contains a table with one row per mapping.
    /// The table columns are: "SIP Status Code", "Treatment Id".
    /// <see cref="SystemTreatmentMappingNetworkSIPStatusGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17918""}]")]
    public class SystemTreatmentMappingNetworkSIPStatusGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

        [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17918")]
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
        public bool TreatmentMappingTableSpecified { get; set; }

    }
}
