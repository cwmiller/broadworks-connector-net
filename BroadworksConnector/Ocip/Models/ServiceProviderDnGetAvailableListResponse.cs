using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDnGetAvailableListRequest.
    /// Contains a list of available DNs not yet assigned to any group.
    /// <see cref="ServiceProviderDnGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3183""}]")]
    public class ServiceProviderDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _availableDn = new List<string>();

        [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3183")]
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
        public bool AvailableDnSpecified { get; set; }

    }
}
