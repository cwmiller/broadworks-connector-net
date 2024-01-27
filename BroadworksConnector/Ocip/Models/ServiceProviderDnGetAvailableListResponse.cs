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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3919""}]")]
    public class ServiceProviderDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _availableDn = new List<string>();

        [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3919")]
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
