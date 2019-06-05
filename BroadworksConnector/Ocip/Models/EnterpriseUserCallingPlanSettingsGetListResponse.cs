using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseUserCallingPlanSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _userCallingPlanTable;

        [XmlElement(ElementName = "userCallingPlanTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable UserCallingPlanTable
        {
            get => _userCallingPlanTable;
            set
            {
                UserCallingPlanTableSpecified = true;
                _userCallingPlanTable = value;
            }
        }

        [XmlIgnore]
        public bool UserCallingPlanTableSpecified { get; set; }
    }
}
