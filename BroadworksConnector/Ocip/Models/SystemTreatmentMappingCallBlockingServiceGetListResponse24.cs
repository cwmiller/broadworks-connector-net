using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemTreatmentMappingCallBlockingServiceGetListRequest24.
    /// Contains a table with one row per mapping.
    /// The table columns are: "Service", "Treatment Id".
    /// 
    /// The Service column list the service or policy which is using corresponding treatment, and can be OCP, EOCP, ICP, ACR, SCR, SCA, AAC, Intercept, PTT, CommBarring, SAC, IncomingCommBarring, HierCommBarring, IncomHierCommBarring, BWMobilityDenyOrig, BWMobilityDenyTerm, ETRouteExhaust, CallPark, NumberPortability, ConcTerminatingAlertingPolicy, AutomaticCollectCall, ETRouteExhaustUnreachable, TCUG, RPAdmission, MaximumRedirectionDepthOnBusy, MaximumRedirectionDepthOnDiversion.
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16036""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

        [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16036")]
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
