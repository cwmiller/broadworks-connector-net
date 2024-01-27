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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18482""}]")]
    public class SystemSystemServiceDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _availableDn = new List<string>();

        [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18482")]
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
