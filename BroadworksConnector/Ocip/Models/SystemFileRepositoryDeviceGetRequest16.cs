using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the file repository information.  The response is either SystemFileRepositoryDeviceGetResponse16 or ErrorResponse.
    /// 
    /// Replaced by: SystemFileRepositoryDeviceGetRequest20
    /// <see cref="SystemFileRepositoryDeviceGetResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemFileRepositoryDeviceGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27292""}]")]
    public class SystemFileRepositoryDeviceGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemFileRepositoryDeviceGetResponse16>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27292")]
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
