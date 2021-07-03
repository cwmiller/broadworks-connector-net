using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemServiceDnGetAvailableListRequest.
    /// Contains a list of available DNs not yet assigned to any instance of system service.
    /// <see cref="SystemSystemServiceDnGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18248""}]")]
    public class SystemSystemServiceDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _availableDn = new List<string>();

        [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18248")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> AvailableDn
        {
            get => _availableDn;
            set
            {
                AvailableDnSpecified = true;
                _availableDn = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableDnSpecified { get; set; }

    }
}
