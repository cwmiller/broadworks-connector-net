using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Profile.
    /// The response is either a SystemCommunicationBarringProfileGetResponse17sp3
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1 in AS data mode
    /// <see cref="SystemCommunicationBarringProfileGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCommunicationBarringProfileGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1419""}]")]
    public class SystemCommunicationBarringProfileGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1419")]
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
