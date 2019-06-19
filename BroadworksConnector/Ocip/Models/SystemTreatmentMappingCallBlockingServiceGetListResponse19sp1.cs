using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1.
    /// Contains a table with one row per mapping.
    /// The table columns are: "Service", "Treatment Id".
    /// The Service column list the service or policy which is using corresponding treatment, and can be OCP,
    /// EOCP, ICP, ACR,
    /// SCR, SCA, AAC, Intercept, PTT, CommBarring, SAC, IncomingCommBarring, HierCommBarring,
    /// IncomHierCommBarring,
    /// BWMobilityDenyOrig, BWMobilityDenyTerm, ETRouteExhaust, CallPark, NumberPortability.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListResponse22
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39989""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

        [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39989")]
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
