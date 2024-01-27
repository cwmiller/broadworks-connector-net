using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Profile.
    /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
    /// <see cref="SystemCommunicationBarringProfileGetResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCommunicationBarringProfileGetRequest19sp1V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9526""}]")]
    public class SystemCommunicationBarringProfileGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringProfileGetResponse19sp1>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9526")]
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
        protected bool NameSpecified { get; set; }

    }
}
