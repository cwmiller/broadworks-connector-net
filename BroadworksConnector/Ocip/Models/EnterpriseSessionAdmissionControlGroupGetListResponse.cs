using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseSessionAdmissionControlGroupGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _sessionAdmissionControlGroupTable;

        [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable SessionAdmissionControlGroupTable
        {
            get => _sessionAdmissionControlGroupTable;
            set
            {
                SessionAdmissionControlGroupTableSpecified = true;
                _sessionAdmissionControlGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool SessionAdmissionControlGroupTableSpecified { get; set; }
    }
}
