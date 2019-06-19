using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the setting that are configured for all the DNIS in a Route Point.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:836""}]")]
    public class GroupRoutePointModifyDNISParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:836")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private bool _displayDNISNumber;

        [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:836")]
        public bool DisplayDNISNumber
        {
            get => _displayDNISNumber;
            set
            {
                DisplayDNISNumberSpecified = true;
                _displayDNISNumber = value;
            }
        }

        [XmlIgnore]
        public bool DisplayDNISNumberSpecified { get; set; }

        private bool _displayDNISName;

        [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:836")]
        public bool DisplayDNISName
        {
            get => _displayDNISName;
            set
            {
                DisplayDNISNameSpecified = true;
                _displayDNISName = value;
            }
        }

        [XmlIgnore]
        public bool DisplayDNISNameSpecified { get; set; }

    }
}
