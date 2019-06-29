using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3147""}]")]
    public class ReplacementCombinedServicePackAssignmentList
    {

        private List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment> _servicePack = new List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment>();

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3147")]
        public List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment> ServicePack
        {
            get => _servicePack;
            set
            {
                ServicePackSpecified = true;
                _servicePack = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackSpecified { get; set; }

    }
}
