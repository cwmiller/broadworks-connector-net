using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterAgentUnavailableCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _unavailableCodesTable;

        [XmlElement(ElementName = "unavailableCodesTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable UnavailableCodesTable
        {
            get => _unavailableCodesTable;
            set
            {
                UnavailableCodesTableSpecified = true;
                _unavailableCodesTable = value;
            }
        }

        [XmlIgnore]
        public bool UnavailableCodesTableSpecified { get; set; }
    }
}
