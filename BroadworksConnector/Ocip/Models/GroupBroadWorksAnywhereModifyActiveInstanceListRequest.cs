using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the active status of BroadWorks Anywhere instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:178""}]")]
    public class GroupBroadWorksAnywhereModifyActiveInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.ServiceActivation> _serviceActivation = new List<BroadWorksConnector.Ocip.Models.ServiceActivation>();

        [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:178")]
        public List<BroadWorksConnector.Ocip.Models.ServiceActivation> ServiceActivation
        {
            get => _serviceActivation;
            set
            {
                ServiceActivationSpecified = true;
                _serviceActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceActivationSpecified { get; set; }

    }
}
