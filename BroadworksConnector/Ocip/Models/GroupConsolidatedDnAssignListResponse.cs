using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupConsolidatedDnAssignListRequest.
    /// <see cref="GroupConsolidatedDnAssignListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3363""}]")]
    public class GroupConsolidatedDnAssignListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnValidationError = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnValidationError", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3363")]
        public List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> DnValidationError
        {
            get => _dnValidationError;
            set
            {
                DnValidationErrorSpecified = true;
                _dnValidationError = value;
            }
        }

        [XmlIgnore]
        protected bool DnValidationErrorSpecified { get; set; }

    }
}
