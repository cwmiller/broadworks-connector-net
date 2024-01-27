using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of service packs that replaces existing service packs assigned to the user.
    /// If a service pack is not authorized to the group, the service will be authorized. The authorizedQuantity will be used if provided; otherwise, the service quantity will be set to unlimited. The command will fail if the authorized Quantity set at the service provider is insufficient
    /// If a service pack is already authorized to the group, the service quantity will be ignored if included.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4349""}]")]
    public class ReplacementConsolidatedServicePackAssignmentList
    {

        protected List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> _servicePack = new List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment>();

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4349")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack
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
