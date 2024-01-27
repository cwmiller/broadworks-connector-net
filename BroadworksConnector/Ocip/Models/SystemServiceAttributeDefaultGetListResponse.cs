using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemServiceAttributeDefaultGetListRequest.
    /// Contains an array Service Attribute entries.
    /// <see cref="SystemServiceAttributeDefaultGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16255""}]")]
    public class SystemServiceAttributeDefaultGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntryRead> _serviceAttributeEntry = new List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntryRead>();

        [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16255")]
        public List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntryRead> ServiceAttributeEntry
        {
            get => _serviceAttributeEntry;
            set
            {
                ServiceAttributeEntrySpecified = true;
                _serviceAttributeEntry = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAttributeEntrySpecified { get; set; }

    }
}
