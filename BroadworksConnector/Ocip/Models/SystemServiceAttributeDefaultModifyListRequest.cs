using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a list of default attributes that are used when assigning the feature.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14913""}]")]
    public class SystemServiceAttributeDefaultModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.ServiceCategory _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14913")]
        public BroadWorksConnector.Ocip.Models.ServiceCategory ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntry> _serviceAttributeEntry = new List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntry>();

        [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14913")]
        public List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntry> ServiceAttributeEntry
        {
            get => _serviceAttributeEntry;
            set
            {
                ServiceAttributeEntrySpecified = true;
                _serviceAttributeEntry = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAttributeEntrySpecified { get; set; }

    }
}
