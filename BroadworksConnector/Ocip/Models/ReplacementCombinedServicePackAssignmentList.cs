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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4251""}]")]
    public class ReplacementCombinedServicePackAssignmentList
    {

        protected List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment> _servicePack = new List<BroadWorksConnector.Ocip.Models.CombinedServicePackAssignment>();

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4251")]
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
