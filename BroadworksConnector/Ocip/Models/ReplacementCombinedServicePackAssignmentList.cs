using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of service packs that replaces existing service packs assgined to the user.
    /// 
    /// If a service pack is already assigned to the user, the service quantitiy will be updated if included.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCombinedServicePackAssignmentList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment> _servicePack;

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment> ServicePack {
            get => _servicePack;
            set {
                ServicePackSpecified = true;
                _servicePack = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackSpecified { get; set; }
        
    }
}
