using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Network Class of Service.
    /// The response is either a SystemNetworkClassOfServiceGetResponse17
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
    /// <see cref="SystemNetworkClassOfServiceGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkClassOfServiceGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1589""}]")]
    public class SystemNetworkClassOfServiceGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1589")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

    }
}
